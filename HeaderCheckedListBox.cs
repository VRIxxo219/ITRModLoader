using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            if (Items[e.Index] is string header && header.StartsWith(HeaderPrefix))
            {
                TextRenderer.DrawText(e.Graphics, header.Substring(HeaderPrefix.Length),
                    new Font(e.Font, FontStyle.Bold), e.Bounds, Color.White, Color.Transparent);
            }
            else if (Items[e.Index] is ModItem modItem)
            {
                Color selectionColor = MaterialSkinManager.Instance.Theme == MaterialSkinManager.Themes.LIGHT
                    ? Color.LightBlue
                    : Color.FromArgb(160, 69, 69);

                Color textColor = MaterialSkinManager.Instance.Theme == MaterialSkinManager.Themes.LIGHT
                    ? (modItem.IsSelected ? Color.Black : Color.Gray)
                    : (modItem.IsSelected ? Color.White : Color.LightGray);
                // Draw selection background if selected
                if (modItem.IsSelected)
                {
                    using (var brush = new SolidBrush(selectionColor))
                    {
                        e.Graphics.FillRectangle(brush, e.Bounds);
                    }
                }

                // Draw checkbox (custom-drawn, but base state is now in sync)
                Rectangle checkboxRect = new Rectangle(e.Bounds.Left + 5, e.Bounds.Top + 5, 16, 16);
                ControlPaint.DrawCheckBox(e.Graphics, checkboxRect,
                    modItem.IsSelected ? ButtonState.Checked : ButtonState.Normal);

                // Draw mod names
                Rectangle nameRect = new Rectangle(
                    checkboxRect.Right + 10,
                    e.Bounds.Top,
                    e.Bounds.Width - checkboxRect.Right - 10 - _columnWidth - 30,
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

                // Draw priority column
                Rectangle priorityRect = new Rectangle(
                    e.Bounds.Right - _columnWidth - 20,
                    e.Bounds.Top,
                    _columnWidth,
                    e.Bounds.Height
                );
                TextRenderer.DrawText(e.Graphics, modItem.Priority.ToString(), e.Font,
                    priorityRect, textColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
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
                modItem.IsSelected = !modItem.IsSelected;
                base.SetItemChecked(index, modItem.IsSelected);
                Invalidate();
                return;
            }
            base.OnMouseDown(e);
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
