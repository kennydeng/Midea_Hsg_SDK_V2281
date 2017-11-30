﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Drawing.Imaging;

namespace GUIDesigner
{
    class RadioBoxWidget : RadioButton, IWidget
    {
        public RadioBoxWidget()
        {
            base.Appearance = System.Windows.Forms.Appearance.Button;
            base.BackColor = SystemColors.ButtonFace;
            base.BackgroundImageLayout = ImageLayout.None;
            base.FlatAppearance.CheckedBackColor = SystemColors.InactiveCaption;
            base.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            base.FlatAppearance.MouseDownBackColor = Color.Transparent;
            base.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.CheckedFontColor = this.ForeColor;
            base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            base.Margin = new Padding(0, 0, 0, 0);
            base.TextAlign = ContentAlignment.MiddleCenter;
            this.TransformType = IconWidget.WidgetTransformType.None;
            this.TransformX = 100;
            this.TransformY = 100;
            this.Action01 = new WidgetAction(ITU.WidgetActionType.None, WidgetEvent.Press, "", "");
            this.Action02 = new WidgetAction(ITU.WidgetActionType.None, WidgetEvent.Press, "", "");
            this.Action03 = new WidgetAction(ITU.WidgetActionType.None, WidgetEvent.Press, "", "");
            this.Action04 = new WidgetAction(ITU.WidgetActionType.None, WidgetEvent.Press, "", "");
            this.Action05 = new WidgetAction(ITU.WidgetActionType.None, WidgetEvent.Press, "", "");
            this.Action06 = new WidgetAction(ITU.WidgetActionType.None, WidgetEvent.Press, "", "");
            this.Action07 = new WidgetAction(ITU.WidgetActionType.None, WidgetEvent.Press, "", "");
            this.Action08 = new WidgetAction(ITU.WidgetActionType.None, WidgetEvent.Press, "", "");
            this.Action09 = new WidgetAction(ITU.WidgetActionType.None, WidgetEvent.Press, "", "");
            this.Action10 = new WidgetAction(ITU.WidgetActionType.None, WidgetEvent.Press, "", "");
            this.Action11 = new WidgetAction(ITU.WidgetActionType.None, WidgetEvent.Press, "", "");
            this.Action12 = new WidgetAction(ITU.WidgetActionType.None, WidgetEvent.Press, "", "");
            this.Action13 = new WidgetAction(ITU.WidgetActionType.None, WidgetEvent.Press, "", "");
            this.Action14 = new WidgetAction(ITU.WidgetActionType.None, WidgetEvent.Press, "", "");
            this.Action15 = new WidgetAction(ITU.WidgetActionType.None, WidgetEvent.Press, "", "");
            this.Compress = true;
            this.External = false;
            this.BoldSize = 1;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public Appearance Appearance { get; set; }

        [Editor(typeof(ImageLocationEditor), typeof(UITypeEditor))]
        public override Image BackgroundImage
        {
            get { return base.BackgroundImage; }
            set { base.BackgroundImage = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public virtual ImageLayout BackgroundImageLayout { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public ContentAlignment CheckAlign { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CheckState CheckState { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public virtual Cursor Cursor { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public FlatStyle FlatStyle { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public Image Image { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public ContentAlignment ImageAlign { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public int ImageIndex { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public string ImageKey { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public ImageList ImageList { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public virtual RightToLeft RightToLeft { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public virtual ContentAlignment TextAlign { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public TextImageRelation TextImageRelation { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public bool UseMnemonic { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public bool UseVisualStyleBackColor { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public bool UseWaitCursor { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public virtual bool AllowDrop { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public bool AutoCheck { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public bool AutoEllipsis { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public virtual ContextMenuStrip ContextMenuStrip { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public bool Enabled { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ThreeState { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public bool UseCompatibleTextRendering { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public string AccessibleDescription { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public string AccessibleName { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public AccessibleRole AccessibleRole { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public virtual AnchorStyles Anchor { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override bool AutoSize { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public virtual DockStyle Dock { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public Padding Margin { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public virtual Size MaximumSize { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public virtual Size MinimumSize { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public Padding Padding { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public bool CausesValidation { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public ControlBindingsCollection DataBindings { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public object Tag { get; set; }

        public ITU.WidgetPixelFormat PixelFormat { get; set; }
        public Boolean Compress { get; set; }
        public Boolean External { get; set; }
        public Boolean ResponseToUpKey { get; set; }

        public Color CheckedFontColor { get; set; }

        [Editor(typeof(ImageLocationEditor), typeof(UITypeEditor))]
        [DefaultValue(typeof(Image), null)]
        public Image FocusImage { get; set; }

        [Editor(typeof(ImageLocationEditor), typeof(UITypeEditor))]
        [DefaultValue(typeof(Image), null)]
        public Image CheckedImage { get; set; }

        [Editor(typeof(ImageLocationEditor), typeof(UITypeEditor))]
        [DefaultValue(typeof(Image), null)]
        public Image FocusCheckedImage { get; set; }

        public int Angle { get; set; }

        public IconWidget.WidgetTransformType TransformType { get; set; }

        private int transformX = 0;
        public int TransformX
        {
            get
            {
                return transformX;
            }

            set
            {
                if (value < 0)
                    transformX = 0;
                else if (value > ITU.ITU_TRANSFORM_MAX_VALUE)
                    transformX = ITU.ITU_TRANSFORM_MAX_VALUE;
                else
                    transformX = value;
            }
        }

        private int transformY = 0;
        public int TransformY
        {
            get
            {
                return transformY;
            }

            set
            {
                if (value < 0)
                    transformY = 0;
                else if (value > ITU.ITU_TRANSFORM_MAX_VALUE)
                    transformY = ITU.ITU_TRANSFORM_MAX_VALUE;
                else
                    transformY = value;
            }
        }

        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        public string Text4 { get; set; }
        public string Text5 { get; set; }
        public string Text6 { get; set; }
        public string Text7 { get; set; }
        public int FontIndex { get; set; }
        public int BoldSize { get; set; }

        public enum WidgetEvent
        {
            Timer = 0,
            Press = 1,
            KeyDown = 4,
            KeyUp = 5,
            MouseDown = 6,
            MouseUp = 7,
            MouseDoubleClick = 8,
            SlideLeft = 10,
            SlideUp = 11,
            SlideRight = 12,
            SlideDown = 13,
            MouseLongPress = 21,
            Delay0 = 25,
            Delay1 = 26,
            Delay2 = 27,
            Delay3 = 28,
            Delay4 = 29,
            Delay5 = 30,
            Delay6 = 31,
            Delay7 = 32,
            Custom0 = 100,
            Custom1 = 101,
            Custom2 = 102,
            Custom3 = 103,
            Custom4 = 104,
            Custom5 = 105,
            Custom6 = 106,
            Custom7 = 107,
            Custom8 = 108,
            Custom9 = 109,
            Custom10 = 110,
            Custom11 = 111,
            Custom12 = 112,
            Custom13 = 113,
            Custom14 = 114,
            Custom15 = 115,
            Custom16 = 116,
            Custom17 = 117,
            Custom18 = 118,
            Custom19 = 119,
            Custom20 = 120,
            Custom21 = 121,
            Custom22 = 122,
            Custom23 = 123,
            Custom24 = 124,
            Custom25 = 125,
            Custom26 = 126,
            Custom27 = 127,
            Custom28 = 128,
            Custom29 = 129,
            Custom30 = 130
        };

        public class WidgetActionTypeConverter : TypeConverter
        {
            public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
                if (sourceType == typeof(string)) return true;
                return base.CanConvertFrom(context, sourceType);
            }

            // Return true if we need to convert into a string.
            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            {
                if (destinationType == typeof(String)) return true;
                return base.CanConvertTo(context, destinationType);
            }

            // Convert from a string.
            public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
            {
                if (value.GetType() == typeof(string))
                {
                    // Split the string separated by commas.
                    string txt = (string)(value);
                    string[] fields = txt.Split(new char[] { ',' });

                    try
                    {
                        ITU.WidgetActionType a = (ITU.WidgetActionType)Enum.Parse(typeof(ITU.WidgetActionType), fields[0]);
                        WidgetEvent e = WidgetEvent.Press;
                        try
                        {
                            e = (WidgetEvent)Enum.Parse(typeof(WidgetEvent), fields[1]);
                        }
                        catch
                        {
                            a = ITU.WidgetActionType.None;
                        }
                        return new WidgetAction(a, e, fields[2], fields[3]);
                    }
                    catch
                    {
                        throw new InvalidCastException(
                            "Cannot convert the string '" +
                            value.ToString() + "' into a Action");
                    }
                }
                else
                {
                    return base.ConvertFrom(context, culture, value);
                }
            }

            public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
            {
                if (destinationType == typeof(string)) return value.ToString();
                return base.ConvertTo(context, culture, value, destinationType);
            }

            public override bool GetPropertiesSupported(ITypeDescriptorContext context)
            {
                return true;
            }

            public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
            {
                return TypeDescriptor.GetProperties(value);
            }
        }

        public class WidgetStringListConverter : TypeConverter
        {
            public override bool
            GetStandardValuesSupported(ITypeDescriptorContext context)
            {
                return true; // display drop
            }
            //public override bool
            //GetStandardValuesExclusive(ITypeDescriptorContext context)
            //{
            //    return true; // drop-down vs combo
            //}
            public override StandardValuesCollection
            GetStandardValues(ITypeDescriptorContext context)
            {
                List<string> names = new List<string>();
                WidgetAction a = (WidgetAction)context.Instance;

                foreach (HostSurface hs in HostSurface.hostSurfaces)
                {
                    Uitlity.GetWidgetNamesByActionType(hs.formDesignerHost.Container.Components, a.Action, names);
                }
                names.Sort();
                return new StandardValuesCollection(names.ToArray());
            }

            public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
            {
                if (sourceType == typeof(string))
                    return true;
                else
                    return base.CanConvertFrom(context, sourceType);
            }

            public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
            {
                if (value.GetType() == typeof(string))
                {
                    string s = value as string;
                    //NameCreationService.AddName(s);
                    return s;
                }
                else
                    return base.ConvertFrom(context, culture, value);
            }
        }

        [Serializable]
        [TypeConverter(typeof(WidgetActionTypeConverter))]
        public struct WidgetAction
        {
            public ITU.WidgetActionType Action { get; set; }
            public WidgetEvent Event { get; set; }

            private volatile string target;
            [TypeConverter(typeof(WidgetStringListConverter))]
            public String Target
            {
                get
                {
                    return target;
                }

                set
                {
                    if (Action == ITU.WidgetActionType.Function && ITU.enterKeyPressed && ITU.layerWidget != null && ITU.projectPath != null)
                    {
                        string funcName = value.Trim();

                        CodeGenerator.InvokeVisualStudio(funcName);

                        target = funcName;
                    }
                    else
                    {
                        target = value;
                    }
                }
            }

            public String Parameter { get; set; }

            public override string ToString()
            {
                return Action + "," + Event + "," + Target + "," + Parameter;
            }

            public WidgetAction(ITU.WidgetActionType action, WidgetEvent ev, String target, String param)
                : this()
            {
                Event = ev;
                Action = action;
                Target = target;
                Parameter = param;
            }
        }

        public WidgetAction Action01 { get; set; }
        public WidgetAction Action02 { get; set; }
        public WidgetAction Action03 { get; set; }
        public WidgetAction Action04 { get; set; }
        public WidgetAction Action05 { get; set; }
        public WidgetAction Action06 { get; set; }
        public WidgetAction Action07 { get; set; }
        public WidgetAction Action08 { get; set; }
        public WidgetAction Action09 { get; set; }
        public WidgetAction Action10 { get; set; }
        public WidgetAction Action11 { get; set; }
        public WidgetAction Action12 { get; set; }
        public WidgetAction Action13 { get; set; }
        public WidgetAction Action14 { get; set; }
        public WidgetAction Action15 { get; set; }

        private bool hided = false;
        public bool Hided
        {
            get
            {
                return hided;
            }

            set
            {
                if (value)
                    Hide();
                else
                    Show();

                hided = value;
            }
        }

        public ITUWidget CreateITUWidget()
        {
            ITURadioBox radiobox = new ITURadioBox();

            radiobox.name = this.Name;
            radiobox.flags |= this.TabStop ? ITU.ITU_TAPSTOP : 0;
            radiobox.flags |= this.ResponseToUpKey ? ITU.ITU_RESPONSE_TO_UP_KEY : 0;

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(this);
            radiobox.visible = (bool)properties["Visible"].GetValue(this);

            radiobox.active = false;
            radiobox.dirty = false;
            radiobox.alpha = 255;
            radiobox.tabIndex = this.TabIndex;
            radiobox.rect.x = this.Location.X;
            radiobox.rect.y = this.Location.Y;
            radiobox.rect.width = this.Size.Width;
            radiobox.rect.height = this.Size.Height;
            radiobox.color.alpha = this.BackColor.A;
            radiobox.color.red = this.BackColor.R;
            radiobox.color.green = this.BackColor.G;
            radiobox.color.blue = this.BackColor.B;
            radiobox.bound.x = 0;
            radiobox.bound.y = 0;
            radiobox.bound.width = 0;
            radiobox.bound.height = 0;

            if (this.BackgroundImage != null)
            {
                radiobox.staticSurf = ITU.CreateSurfaceNode(this.BackgroundImage as Bitmap, this.PixelFormat, this.Compress, this.External);
                if (this.External)
                    radiobox.flags |= ITU.ITU_EXTERNAL;
            }

            ITUBorderWindow bwin = radiobox.bwin.widget as ITUBorderWindow;
            bwin.name = "";
            bwin.visible = true;
            bwin.active = false;
            bwin.dirty = false;
            bwin.alpha = 255;
            bwin.rect.x = 0;
            bwin.rect.y = 0;
            bwin.rect.width = this.Size.Width;
            bwin.rect.height = this.Size.Height;
            bwin.color.alpha = this.FlatAppearance.BorderColor.A;
            bwin.color.red = this.FlatAppearance.BorderColor.R;
            bwin.color.green = this.FlatAppearance.BorderColor.G;
            bwin.color.blue = this.FlatAppearance.BorderColor.B;
            bwin.bound.x = 0;
            bwin.bound.y = 0;
            bwin.bound.width = 0;
            bwin.bound.height = 0;
            bwin.borderSize = this.FlatAppearance.BorderSize;

            ITUText text = radiobox.text.widget as ITUText;
            text.flags = ITU.ITU_CLIP_DISABLED;
            text.name = "";
            text.visible = true;
            text.active = false;
            text.dirty = false;
            text.alpha = 255;
            text.rect.x = 0;
            text.rect.y = 0;

            using (Graphics cg = this.CreateGraphics())
            {
                SizeF size = cg.MeasureString(this.Text, this.Font);

                text.rect.width = (int)Math.Ceiling(size.Width);
                text.rect.height = (int)Math.Ceiling(size.Height);
            }
            text.color.alpha = this.ForeColor.A;
            text.color.red = this.ForeColor.R;
            text.color.green = this.ForeColor.G;
            text.color.blue = this.ForeColor.B;
            text.bound.x = 0;
            text.bound.y = 0;
            text.bound.width = 0;
            text.bound.height = 0;
            text.fontWidth = (int)Math.Round(this.Font.Size * (this.Font.FontFamily.GetCellAscent(FontStyle.Regular) + this.Font.FontFamily.GetCellDescent(FontStyle.Regular)) / this.Font.FontFamily.GetEmHeight(FontStyle.Regular));
            text.fontHeight = text.fontWidth;
            text.fontIndex = this.FontIndex;
            text.layout = ITULayout.ITU_LAYOUT_MIDDLE_CENTER;

            if (base.Font.Bold)
                text.textFlags |= ITUText.ITU_TEXT_BOLD;

            text.boldSize = this.BoldSize;

            string[] texts = new string[] { this.Text, this.Text1, this.Text2, this.Text3, this.Text4, this.Text5, this.Text6, this.Text7 };
            text.stringSet = ITU.CreateStringSetNode(texts);

            radiobox.bgColor.alpha = this.BackColor.A;
            radiobox.bgColor.red = this.BackColor.R;
            radiobox.bgColor.green = this.BackColor.G;
            radiobox.bgColor.blue = this.BackColor.B;
            radiobox.focusColor.alpha = this.FlatAppearance.MouseOverBackColor.A;
            radiobox.focusColor.red = this.FlatAppearance.MouseOverBackColor.R;
            radiobox.focusColor.green = this.FlatAppearance.MouseOverBackColor.G;
            radiobox.focusColor.blue = this.FlatAppearance.MouseOverBackColor.B;

            if (this.FocusImage != null)
            {
                radiobox.staticFocusSurf = ITU.CreateSurfaceNode(this.FocusImage as Bitmap, this.PixelFormat, this.Compress, this.External);
                if (this.External)
                    radiobox.flags |= ITU.ITU_EXTERNAL;
            }                        
            radiobox.pressColor.alpha = this.FlatAppearance.MouseDownBackColor.A;
            radiobox.pressColor.red = this.FlatAppearance.MouseDownBackColor.R;
            radiobox.pressColor.green = this.FlatAppearance.MouseDownBackColor.G;
            radiobox.pressColor.blue = this.FlatAppearance.MouseDownBackColor.B;
            radiobox.pressed = 0;

            radiobox.checkedColor.alpha = this.FlatAppearance.CheckedBackColor.A;
            radiobox.checkedColor.red = this.FlatAppearance.CheckedBackColor.R;
            radiobox.checkedColor.green = this.FlatAppearance.CheckedBackColor.G;
            radiobox.checkedColor.blue = this.FlatAppearance.CheckedBackColor.B;

            radiobox.checkedFontColor.alpha = this.CheckedFontColor.A;
            radiobox.checkedFontColor.red = this.CheckedFontColor.R;
            radiobox.checkedFontColor.green = this.CheckedFontColor.G;
            radiobox.checkedFontColor.blue = this.CheckedFontColor.B;
            radiobox.orgFontColor.alpha = this.ForeColor.A;
            radiobox.orgFontColor.red = this.ForeColor.R;
            radiobox.orgFontColor.green = this.ForeColor.G;
            radiobox.orgFontColor.blue = this.ForeColor.B;

            if (this.CheckedImage != null)
            {
                radiobox.staticCheckedSurf = ITU.CreateSurfaceNode(this.CheckedImage as Bitmap, this.PixelFormat, this.Compress, this.External);
                if (this.External)
                    radiobox.flags |= ITU.ITU_EXTERNAL;
            }            
            radiobox._checked = this.Checked ? 1 : 0;

            if (this.FocusCheckedImage != null)
            {
                radiobox.staticFocusCheckedSurf = ITU.CreateSurfaceNode(this.FocusCheckedImage as Bitmap, this.PixelFormat, this.Compress, this.External);
                if (this.External)
                    radiobox.flags |= ITU.ITU_EXTERNAL;
            }

            radiobox.angle = this.Angle;
            radiobox.transformType = (ITUTransformType)this.TransformType;
            radiobox.transformX = this.TransformX;
            radiobox.transformY = this.TransformY;

            radiobox.actions[0].action = (ITUActionType)this.Action01.Action;
            radiobox.actions[0].ev = (ITUEvent)this.Action01.Event;
            radiobox.actions[0].target = this.Action01.Target;
            radiobox.actions[0].param = this.Action01.Parameter;
            radiobox.actions[1].action = (ITUActionType)this.Action02.Action;
            radiobox.actions[1].ev = (ITUEvent)this.Action02.Event;
            radiobox.actions[1].target = this.Action02.Target;
            radiobox.actions[1].param = this.Action02.Parameter;
            radiobox.actions[2].action = (ITUActionType)this.Action03.Action;
            radiobox.actions[2].ev = (ITUEvent)this.Action03.Event;
            radiobox.actions[2].target = this.Action03.Target;
            radiobox.actions[2].param = this.Action03.Parameter;
            radiobox.actions[3].action = (ITUActionType)this.Action04.Action;
            radiobox.actions[3].ev = (ITUEvent)this.Action04.Event;
            radiobox.actions[3].target = this.Action04.Target;
            radiobox.actions[3].param = this.Action04.Parameter;
            radiobox.actions[4].action = (ITUActionType)this.Action05.Action;
            radiobox.actions[4].ev = (ITUEvent)this.Action05.Event;
            radiobox.actions[4].target = this.Action05.Target;
            radiobox.actions[4].param = this.Action05.Parameter;
            radiobox.actions[5].action = (ITUActionType)this.Action06.Action;
            radiobox.actions[5].ev = (ITUEvent)this.Action06.Event;
            radiobox.actions[5].target = this.Action06.Target;
            radiobox.actions[5].param = this.Action06.Parameter;
            radiobox.actions[6].action = (ITUActionType)this.Action07.Action;
            radiobox.actions[6].ev = (ITUEvent)this.Action07.Event;
            radiobox.actions[6].target = this.Action07.Target;
            radiobox.actions[6].param = this.Action07.Parameter;
            radiobox.actions[7].action = (ITUActionType)this.Action08.Action;
            radiobox.actions[7].ev = (ITUEvent)this.Action08.Event;
            radiobox.actions[7].target = this.Action08.Target;
            radiobox.actions[7].param = this.Action08.Parameter;
            radiobox.actions[8].action = (ITUActionType)this.Action09.Action;
            radiobox.actions[8].ev = (ITUEvent)this.Action09.Event;
            radiobox.actions[8].target = this.Action09.Target;
            radiobox.actions[8].param = this.Action09.Parameter;
            radiobox.actions[9].action = (ITUActionType)this.Action10.Action;
            radiobox.actions[9].ev = (ITUEvent)this.Action10.Event;
            radiobox.actions[9].target = this.Action10.Target;
            radiobox.actions[9].param = this.Action10.Parameter;
            radiobox.actions[10].action = (ITUActionType)this.Action11.Action;
            radiobox.actions[10].ev = (ITUEvent)this.Action11.Event;
            radiobox.actions[10].target = this.Action11.Target;
            radiobox.actions[10].param = this.Action11.Parameter;
            radiobox.actions[11].action = (ITUActionType)this.Action12.Action;
            radiobox.actions[11].ev = (ITUEvent)this.Action12.Event;
            radiobox.actions[11].target = this.Action12.Target;
            radiobox.actions[11].param = this.Action12.Parameter;
            radiobox.actions[12].action = (ITUActionType)this.Action13.Action;
            radiobox.actions[12].ev = (ITUEvent)this.Action13.Event;
            radiobox.actions[12].target = this.Action13.Target;
            radiobox.actions[12].param = this.Action13.Parameter;
            radiobox.actions[13].action = (ITUActionType)this.Action14.Action;
            radiobox.actions[13].ev = (ITUEvent)this.Action14.Event;
            radiobox.actions[13].target = this.Action14.Target;
            radiobox.actions[13].param = this.Action14.Parameter;
            radiobox.actions[14].action = (ITUActionType)this.Action15.Action;
            radiobox.actions[14].ev = (ITUEvent)this.Action15.Event;
            radiobox.actions[14].target = this.Action15.Target;
            radiobox.actions[14].param = this.Action15.Parameter;

            return radiobox;
        }

        public void SaveImages(String path)
        {
            if (this.BackgroundImage != null)
            {
                Bitmap bitmap = this.BackgroundImage as Bitmap;
                String filePath = path + "\\" + this.Name + "_BackgroundImage.png";
                bitmap.Save(filePath, ImageFormat.Png);
            }

            if (this.FocusImage != null)
            {
                Bitmap bitmap = this.FocusImage as Bitmap;
                String filePath = path + "\\" + this.Name + "_FocusImage.png";
                bitmap.Save(filePath, ImageFormat.Png);
            }

            if (this.CheckedImage != null)
            {
                Bitmap bitmap = this.CheckedImage as Bitmap;
                String filePath = path + "\\" + this.Name + "_CheckedImage.png";
                bitmap.Save(filePath, ImageFormat.Png);
            }

            if (this.FocusCheckedImage != null)
            {
                Bitmap bitmap = this.FocusCheckedImage as Bitmap;
                String filePath = path + "\\" + this.Name + "_FocusCheckedImage.png";
                bitmap.Save(filePath, ImageFormat.Png);
            }
        }

        public void WriteFunctions(HashSet<string> functions)
        {
            if (this.Action01.Action == ITU.WidgetActionType.Function)
                functions.Add(this.Action01.Target);
            if (this.Action02.Action == ITU.WidgetActionType.Function)
                functions.Add(this.Action02.Target);
            if (this.Action03.Action == ITU.WidgetActionType.Function)
                functions.Add(this.Action03.Target);
            if (this.Action04.Action == ITU.WidgetActionType.Function)
                functions.Add(this.Action04.Target);
            if (this.Action05.Action == ITU.WidgetActionType.Function)
                functions.Add(this.Action05.Target);
            if (this.Action06.Action == ITU.WidgetActionType.Function)
                functions.Add(this.Action06.Target);
            if (this.Action07.Action == ITU.WidgetActionType.Function)
                functions.Add(this.Action07.Target);
            if (this.Action08.Action == ITU.WidgetActionType.Function)
                functions.Add(this.Action08.Target);
            if (this.Action09.Action == ITU.WidgetActionType.Function)
                functions.Add(this.Action09.Target);
            if (this.Action10.Action == ITU.WidgetActionType.Function)
                functions.Add(this.Action10.Target);
            if (this.Action11.Action == ITU.WidgetActionType.Function)
                functions.Add(this.Action11.Target);
            if (this.Action12.Action == ITU.WidgetActionType.Function)
                functions.Add(this.Action12.Target);
            if (this.Action13.Action == ITU.WidgetActionType.Function)
                functions.Add(this.Action13.Target);
            if (this.Action14.Action == ITU.WidgetActionType.Function)
                functions.Add(this.Action14.Target);
            if (this.Action15.Action == ITU.WidgetActionType.Function)
                functions.Add(this.Action15.Target);
        }
    }
}
