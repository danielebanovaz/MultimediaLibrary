/*using System;
using System.Linq;

namespace MediaLibrary.Core.Reflection
{
    public abstract class MultimediaItem
    {
        public string Title { get; private set; }
        public int Year { get; private set; }
        public bool IsLent { get; private set; }

        protected MultimediaItem(string[] data)
        {
            Title = data[1];
            Year = Convert.ToInt32(data[4]);
            IsLent = Convert.ToBoolean(data[5]);
        }

        public static MultimediaItem ParseMultimediaItem(string record)
        {
            string[] data = record.Split(';');
            switch (data[0])
            {
                case "A": return new Album(data);
                case "M": return new Movie(data);
                case "B": return new Book(data);
                case "V": return new Videogame(data);

                default: return null;
            }
        }

        public static string GetHeaders(string mediaType)
        {
            mediaType = mediaType.ToLower();
            string specificHeaders;
            switch (mediaType)
            {
                case "a": case "album": specificHeaders = FormatStrings(true, "Artist", "Duration"); break;
                case "m": case "movie": specificHeaders = FormatStrings(true, "Director", "Production"); break;
                case "b": case "book": specificHeaders = FormatStrings(true, "Author", "Pages"); break;
                case "v": case "videogame": specificHeaders = FormatStrings(true, "SoftwareHouse", "HasMultiplayer"); break;

                default: return null;
            }

            return FormatStrings(true, "Is Lent", "Title", "Year") + "|" + specificHeaders;
        }

        public string GetProperty(string propertyName)
        {
            propertyName = propertyName.ToLower();
            switch (propertyName)
            {
                case "t": case "title": return Title;
                case "y": case "year": return Year.ToString();
                case "i": case "islent": return IsLent.ToString();

                default: return GetMediaSpecificProperty(propertyName);
            }
        }

        public string DetailedInformation
        { 
            get
            {
                return FormatStrings(false, PropertyValues);
            }
        }

        protected static string FormatStrings(bool showKeyHint, params string[] inputs)
        {
            for (int i = 0; i < inputs.Length; i++)
                inputs[i] = FormatString(showKeyHint, inputs[i]);

            return string.Join('|', inputs);
        }

        protected static string FormatString(bool showKeyHint, string input)
        {
            if (showKeyHint)
                input = $"[{input[0].ToString().ToUpper()}]{input.Substring(1, input.Length - 1)}";

            return $" {input}".PadRight(21);
        }

        protected abstract string MediaSpecificInformation { get; }

        protected abstract string GetMediaSpecificProperty(string propertyName);

        protected string[] PropertyNames
        {
            get
            {
                return this.GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)
                    .Select(p => p.Name)
                    .ToArray();
            }
        }

        protected string[] PropertyValues
        {
            get
            {
                return this.GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)
                    .Select(p => p.GetValue(this).ToString())
                    .ToArray();
            }
        }


    }
}*/
