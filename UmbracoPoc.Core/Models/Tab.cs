using BlueLeet.UCodeFirst;

namespace UmbracoPoc.Web.Business.Models
{
    [TabRoot]
    public enum Tab
    {
        [EnumName("#ContentTab")]
        Content,

        [EnumName("#PushTab")]
        Push,

        [EnumName("#ModuleContentTab")]
        ModuleContent,

        [EnumName("#PageTab")]
        Page,

        [EnumName("#SeoTab")]
        Seo,

        [EnumName("#NavigationTab")]
        Navigation,

        [EnumName("#SiteTab")]
        Site,

        [EnumName("#MailSettingsTab")]
        MailSettings,

        [EnumName("#PackageTab")]
        Package,

        [EnumName("#FooterTab")]
        Footer,

        [EnumName("#GlobalsTab")]
        Globals,

        [EnumName("#AppSectionSettingsTab")]
        AppSectionSettings
    }
}