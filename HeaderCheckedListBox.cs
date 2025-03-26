using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;

namespace ITRModLoader
{
    public class ModItem
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public bool IsSelected { get; set; }
    }

    public class HeaderCheckedListBox : CheckedListBox
    {
        private const string HeaderPrefix = "###HEADER###";
        private Color _selectedColor = Color.FromArgb(40, 90, 255);
        private int _columnWidth = 50; // Width for the priority column
        private int _headerHeight = 24;
        private TextBox priorityEditor;
        private int editingIndex = -1;

        public Color SelectedColor
        {
            get => _selectedColor;
            set => _selectedColor = value;
        }

        public int ColumnWidth
        {
            get => _columnWidth;
            set => _columnWidth = value;
        }

        public HeaderCheckedListBox()
        {
            DoubleBuffered = true;
            IntegralHeight = false;
            DrawMode = DrawMode.OwnerDrawVariable;

            // Setup the TextBox for inline editing of priority.
            priorityEditor = new TextBox();
            priorityEditor.Visible = false;
            priorityEditor.BorderStyle = BorderStyle.FixedSingle;
            priorityEditor.KeyDown += PriorityEditor_KeyDown;
            priorityEditor.LostFocus += PriorityEditor_LostFocus;
            this.Controls.Add(priorityEditor);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // Add validation for index
            if (e.Index < 0 || e.Index >= Items.Count)
                return;

            e.DrawBackground();

            if (Items[e.Index] is string header && header.StartsWith(HeaderPrefix))
            {
                string headerText = header.Substring(HeaderPrefix.Length);
                // Draw header text on the left using a bold font.
                TextRenderer.DrawText(e.Graphics, headerText,
                    new Font(e.Font, FontStyle.Bold), e.Bounds, Color.White, Color.Transparent);

                // If this is the Active Mods header, add the "Mod Priority" label in the priority column area.
                if (headerText.Equals("Active Mods", StringComparison.OrdinalIgnoreCase))
                {
                    Rectangle priorityRect = new Rectangle(
                        e.Bounds.Right - _columnWidth - 20,
                        e.Bounds.Top,
                        _columnWidth,
                        e.Bounds.Height
                    );
                    TextRenderer.DrawText(e.Graphics, "Priority", new Font(e.Font, FontStyle.Bold),
                        priorityRect, Color.White,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
            }
            else if (Items[e.Index] is ModItem modItem)
            {
                Color selectionColor = Color.FromArgb(60, 227, 30, 40);
                Color textColor = modItem.IsSelected
                    ? Color.FromArgb(255, 255, 255)   // White when selected
                    : Color.FromArgb(211, 211, 211);  // LightGray when not selected
                Color checkboxBorderColor = Color.FromArgb(40, 40, 40);
                Color separatorColor = Color.FromArgb(40, 40, 40);

                // Draw selection background if selected
                if (modItem.IsSelected)
                {
                    using (var brush = new SolidBrush(selectionColor))
                    {
                        e.Graphics.FillRectangle(brush, e.Bounds);
                    }
                }

                // Determine checkbox dimensions and center it vertically
                int checkboxSize = 16;
                int checkboxX = e.Bounds.Left + 8;
                int checkboxY = e.Bounds.Top + (e.Bounds.Height - checkboxSize) / 2;
                Rectangle checkboxRect = new Rectangle(checkboxX, checkboxY, checkboxSize, checkboxSize);

                // Draw modern checkbox with rounded corners
                using (var path = new GraphicsPath())
                {
                    int radius = 2;
                    int diameter = radius * 2;

                    // Create rounded rectangle manually
                    path.AddArc(checkboxRect.X, checkboxRect.Y, diameter, diameter, 180, 90);
                    path.AddArc(checkboxRect.Right - diameter, checkboxRect.Y, diameter, diameter, 270, 90);
                    path.AddArc(checkboxRect.Right - diameter, checkboxRect.Bottom - diameter, diameter, diameter, 0, 90);
                    path.AddArc(checkboxRect.X, checkboxRect.Bottom - diameter, diameter, diameter, 90, 90);
                    path.CloseFigure();

                    using (var brush = new SolidBrush(checkboxBorderColor))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                    using (var pen = new Pen(checkboxBorderColor))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }

                    // Draw checkmark if selected
                    if (modItem.IsSelected)
                    {
                        using (var brush = new SolidBrush(textColor))
                        {
                            e.Graphics.DrawString("✓", new Font(e.Font.FontFamily, 10, FontStyle.Bold),
                                brush, checkboxRect.X + 2, checkboxRect.Y + 1);
                        }
                    }
                }

                // Draw mod names
                Rectangle nameRect = new Rectangle(
                    checkboxRect.Right + 12,
                    e.Bounds.Top,
                    e.Bounds.Width - checkboxRect.Right - 12 - _columnWidth - 30,
                    e.Bounds.Height
                );
                TextRenderer.DrawText(
                    e.Graphics,
                    modItem.Name,
                    e.Font,
                    nameRect,
                    textColor,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter
                );

                // Draw priority column for mod items
                Rectangle priorityRectMod = new Rectangle(
                    e.Bounds.Right - _columnWidth - 20,
                    e.Bounds.Top,
                    _columnWidth,
                    e.Bounds.Height
                );
                TextRenderer.DrawText(e.Graphics, modItem.Priority.ToString(), e.Font,
                    priorityRectMod, textColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                // Draw separator line
                if (e.Index < Items.Count - 1)
                {
                    using (var pen = new Pen(separatorColor, 1))
                    {
                        e.Graphics.DrawLine(pen,
                            e.Bounds.Left + 8, e.Bounds.Bottom - 1,
                            e.Bounds.Right - 20, e.Bounds.Bottom - 1);
                    }
                }
            }
        }
        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            base.OnMeasureItem(e);
            if (Items[e.Index] is string header && header.StartsWith(HeaderPrefix))
            {
                e.ItemHeight = _headerHeight;
            }
            else
            {
                e.ItemHeight = 24; // Consistent height for mod items
            }
        }

        public void AddHeader(string text)
        {
            Items.Add(HeaderPrefix + text);
        }

        public void AddModItem(ModItem modItem)
        {
            Items.Add(modItem);
            // Optionally set the base check state:
            int index = Items.IndexOf(modItem);
            base.SetItemChecked(index, modItem.IsSelected);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            int index = IndexFromPoint(e.Location);
            if (index >= 0 && index < Items.Count && Items[index] is ModItem modItem)
            {
                // Get the bounds of the clicked item.
                Rectangle itemBounds = GetItemRectangle(index);
                // Calculate the priority column area.
                Rectangle priorityRect = new Rectangle(
                    itemBounds.Right - _columnWidth - 20,
                    itemBounds.Top,
                    _columnWidth,
                    itemBounds.Height
                );

                // Use right-click for editing priority.
                if (e.Button == MouseButtons.Right && priorityRect.Contains(e.Location))
                {
                    BeginPriorityEdit(index, modItem, priorityRect);
                    return;
                }
                // Left-click toggles the selection state.
                else if (e.Button == MouseButtons.Left)
                {
                    modItem.IsSelected = !modItem.IsSelected;
                    base.SetItemChecked(index, modItem.IsSelected);
                    Invalidate();
                    return;
                }
            }
            base.OnMouseDown(e);
        }

        private void BeginPriorityEdit(int index, ModItem modItem, Rectangle editRect)
        {
            editingIndex = index;
            priorityEditor.Bounds = editRect;
            priorityEditor.Text = modItem.Priority.ToString();
            priorityEditor.Visible = true;
            priorityEditor.Focus();
            priorityEditor.SelectAll();
        }

        private void EndPriorityEdit()
        {
            if (editingIndex >= 0 && editingIndex < Items.Count && Items[editingIndex] is ModItem modItem)
            {
                if (int.TryParse(priorityEditor.Text, out int newPriority))
                {
                    modItem.Priority = newPriority;
                }
            }
            priorityEditor.Visible = false;
            editingIndex = -1;
            Invalidate();
        }

        private void PriorityEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EndPriorityEdit();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                priorityEditor.Visible = false;
                editingIndex = -1;
                Invalidate();
            }
        }

        private void PriorityEditor_LostFocus(object sender, EventArgs e)
        {
            EndPriorityEdit();
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);

            if (SelectedIndex >= 0 && SelectedIndex < Items.Count)
            {
                if (Items[SelectedIndex] is string header && header.StartsWith(HeaderPrefix))
                {
                    SelectedIndex = -1;
                }
            }
        }

        public new void SetItemChecked(int index, bool value)
        {
            if (index >= 0 && index < Items.Count)
            {
                if (Items[index] is ModItem modItem)
                {
                    modItem.IsSelected = value;
                    base.SetItemChecked(index, value);
                    Invalidate();
                }
            }
        }

        public new bool GetItemChecked(int index)
        {
            if (index >= 0 && index < Items.Count)
            {
                if (Items[index] is ModItem modItem)
                {
                    return modItem.IsSelected;
                }
            }
            return false;
        }

        public new void SelectAll()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i] is ModItem modItem)
                {
                    modItem.IsSelected = true;
                    base.SetItemChecked(i, true);
                }
            }
            Invalidate();
        }

        public new void SelectNone()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i] is ModItem modItem)
                {
                    modItem.IsSelected = false;
                    base.SetItemChecked(i, false);
                }
            }
            Invalidate();
        }

        public new void ToggleItemCheck(int index)
        {
            if (index >= 0 && index < Items.Count)
            {
                if (Items[index] is ModItem modItem)
                {
                    modItem.IsSelected = !modItem.IsSelected;
                    base.SetItemChecked(index, modItem.IsSelected);
                    Invalidate();
                }
            }
        }

        public new List<ModItem> GetCheckedModItems()
        {
            return Items.Cast<object>()
                .Where(item => item is ModItem && ((ModItem)item).IsSelected)
                .Cast<ModItem>()
                .ToList();
        }
    }
}