using System;
using System.Windows.Markup;

namespace TableTetaUI.Converter
{
    public sealed class Int32Extension : MarkupExtension
    {
        public Int32Extension(int value) { this.Value = value; }
        public int Value { get; set; }
        public override Object ProvideValue(IServiceProvider sp) { return Value; }
    };
}
