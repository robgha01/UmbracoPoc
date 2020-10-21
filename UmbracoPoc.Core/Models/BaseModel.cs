using BlueLeet.UCodeFirst;
using BlueLeet.UCodeFirst.ContentTypes;
using BlueLeet.UCodeFirst.Extensions;
using Umbraco.Core.Models.PublishedContent;

namespace UmbracoPoc.Core.Models
{
    [ContentType(DisplayName = "Base", Icon = Icon.Brick)]
    public abstract class BaseModel : UCodeFirstContentTypeBase
    {
        protected BaseModel(IPublishedContent content)
            : base(content)
        {
        }

        public StartPageModel StartPage => this.AncestorOrSelf<StartPageModel>(1);
    }
}
