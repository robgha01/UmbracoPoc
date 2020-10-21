using BlueLeet.UCodeFirst.Macros;

namespace UmbracoPoc.Core.Macros
{    
    [MacroType(
        DisplayName = "Jumbotron",
        UseInEditor = true,
        RenderContent = true
    )]
    public class Jumbotron : UCodeFirstMacroTypeBase
    {
        [MacroProperty(MacroParameterType.Textbox)]
        public virtual string Heading { get; set; }

        [MacroProperty(MacroParameterType.Textarea)]
        public virtual string Text { get; set; }
    }
}