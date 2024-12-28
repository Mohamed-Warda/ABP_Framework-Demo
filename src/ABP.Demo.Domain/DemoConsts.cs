using Volo.Abp.Identity;

namespace ABP.Demo;

public static class DemoConsts
{
    public const string DbTablePrefix = "App";
    public const string? DbSchema = null;
    public const string AdminEmailDefaultValue = IdentityDataSeedContributor.AdminEmailDefaultValue;
    public const string AdminPasswordDefaultValue = IdentityDataSeedContributor.AdminPasswordDefaultValue;
    
    public const int GeneralTextMaxLength = 300;
    public const int DescriptionTextMaxLength = 1000;
}
