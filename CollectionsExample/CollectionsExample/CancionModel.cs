using System;
namespace CollectionsExample
{
    public class CancionModel:Java.Lang.Object
    {

        public String Title { get; set; }

        public String Subtitle { get; set; }

        public String PublishDate { get; set; }

        public CancionModel()
        {
        }

        public override string ToString()
        {
            return string.Format("[CancionModel: Title={0}, Subtitle={1}, PublishDate={2}]", Title, Subtitle, PublishDate);
        }
    }
}
