namespace Sharp.CSS.Types
{
    public class BorderImage : BaseCssValue
    {
        public BorderImage(string value)
            : base(value)
        {
        }

        public BorderImage(ImageSource source, BorderImageSlice slice)
            : this($"{source} {slice}")
        {
        }

        public BorderImage(ImageSource source, BorderImageSlice slice, BorderImageRepeat repeat)
            : this($"{source} {slice} {repeat}")
        {
        }

        public BorderImage(ImageSource source, BorderImageSlice slice, BorderImageWidth width)
            : this($"{source} {slice} / {width}")
        {
        }

        public BorderImage(ImageSource source, BorderImageSlice slice, BorderImageWidth width, BorderImageOutset outset)
            : this($"{source} {slice} / {width} / {outset}")
        {
        }

        public BorderImage(ImageSource source, BorderImageSlice slice, BorderImageWidth width, BorderImageOutset outset, BorderImageRepeat repeat)
            : this($"{source} {slice} / {width} / {outset} {repeat}")
        {
        }

        public static implicit operator BorderImage(string value) => new BorderImage(value);

        public static readonly BorderImage Initial = new BorderImage("initial");
        public static readonly BorderImage Inherit = new BorderImage("inherit");
    }
}
