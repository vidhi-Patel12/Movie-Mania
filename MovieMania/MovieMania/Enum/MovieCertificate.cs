using System.ComponentModel.DataAnnotations;

public enum MovieCertificate
{
    [Display(Name = "Universal (U)")]
    U,

    [Display(Name = "Parental Guidance (U/A)")]
    U_A,

    [Display(Name = "Adults Only (A)")]
    A,

    [Display(Name = "Special Audience (S)")]
    S,

    [Display(Name = "General Audience (G)")]
    G,

    [Display(Name = "Parental Guidance (PG)")]
    PG,

    [Display(Name = "7+ (Ages 7 and up)")]
    SevenPlus,

    [Display(Name = "13+ (Ages 13 and up)")]
    ThirteenPlus,

    [Display(Name = "Mature Audience (M)")]
    M,

    [Display(Name = "Mature Audience Accompanied by Adult (MA)")]
    MA,

    [Display(Name = "16+ (Ages 16 and up)")]
    SixteenPlus,

    [Display(Name = "Restricted (R)")]
    R,

    [Display(Name = "18+ (Ages 18 and up)")]
    EighteenPlus,

    [Display(Name = "Explicit Content (X)")]
    X
}
