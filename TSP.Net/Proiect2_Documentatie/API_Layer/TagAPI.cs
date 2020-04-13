


using MyPhotos.Context;
using System.Collections.Generic;
using System.Linq;


namespace MyPhotoAPI
{
    public class TagAPI
    {
        static public List<Tags> GetTags(Model1Container context)
        {
            List<Tags> tags = context.Tags.ToList();
            return tags;
        }

        static public List<Tags> GetPhotoTags(string photoTags, Model1Container context)
        {
            string[] tags = photoTags.Split(' ');
            CreateNonExistentTags(tags, context);
            List<Tags> returnTags = GetTagsByList(tags, context);
            return returnTags;
        }

        static private List<Tags> GetTagsByList(string[] tags,Model1Container context)
        {
            IEnumerable<Tags> contextTags = context.Tags.ToList();
            List<Tags> returnTags = new List<Tags>();
            foreach(string tag in tags)
            {
                foreach (Tags contextTag in contextTags)
                    if (contextTag.Description.ToLower().Equals(tag.ToLower()))
                        returnTags.Add(contextTag);
            }
            return returnTags;
        }

        static private void CreateNonExistentTags(string[] tags, Model1Container context)
        {
            foreach(string tag in tags)
            {
                if (!Exists(tag, context))
                    CreateTag(tag, context);
            }
        }

        static private bool Exists(string tagName, Model1Container context)
        {
            List<Tags> tags = GetTags(context);
            foreach(Tags tag in tags)
            {
                if (tag.Description.Equals(tagName))
                    return true;
            }
            return false;
        }

        static private void CreateTag(string tagName, Model1Container context)
        {
            Tags tag = new Tags
            {
                Description = tagName
            };
            context.Tags.Add(tag);
            context.SaveChanges();
        }
    }
}
