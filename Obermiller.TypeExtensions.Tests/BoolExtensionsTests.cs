using Xunit;

namespace Obermiller.TypeExtensions.Tests;

public class BoolExtensionsTests
{
    #region FromYesNo
    
    #region True

    [Fact]
    public void FromYesNo_yes_True() => Assert.True("yes".FromYesNo());
    
    [Fact]
    public void FromYesNo_Yes_True() => Assert.True("Yes".FromYesNo());
    
    [Fact]
    public void FromYesNo_yEs_True() => Assert.True("yEs".FromYesNo());
    
    [Fact]
    public void FromYesNo_yeS_True() => Assert.True("yeS".FromYesNo());
    
    [Fact]
    public void FromYesNo_YEs_True() => Assert.True("YEs".FromYesNo());
    
    [Fact]
    public void FromYesNo_YeS_True() => Assert.True("YeS".FromYesNo());
    
    [Fact]
    public void FromYesNo_yES_True() => Assert.True("yES".FromYesNo());
    
    [Fact]
    public void FromYesNo_YES_True() => Assert.True("YES".FromYesNo());
    
    #endregion

    #region False

    [Fact]
    public void FromYesNo_no_False() => Assert.False("no".FromYesNo());
    
    [Fact]
    public void FromYesNo_No_False() => Assert.False("No".FromYesNo());
    
    [Fact]
    public void FromYesNo_nO_False() => Assert.False("nO".FromYesNo());
    
    [Fact]
    public void FromYesNo_NO_False() => Assert.False("NO".FromYesNo());

    [Fact]
    public void FromYesNo_AnYtHiNg_False() => Assert.False("AnYtHiNg".FromYesNo());

    #endregion

    #endregion

    #region FromYN
    
    #region True

    [Fact]
    public void FromYN_y_True() => Assert.True("y".FromYN());
    
    [Fact]
    public void FromYN_Y_True() => Assert.True("Y".FromYN());
    
    #endregion

    #region False

    [Fact]
    public void FromYN_n_False() => Assert.False("n".FromYN());
    
    [Fact]
    public void FromYN_N_False() => Assert.False("N".FromYN());
    
    [Fact]
    public void FromYN_yes_False() => Assert.False("yes".FromYN());
    
    [Fact]
    public void FromYN_no_False() => Assert.False("no".FromYN());
    
    [Fact]
    public void FromYN_AnYtHiNg_False() => Assert.False("AnYtHiNg".FromYN());

    #endregion

    #endregion

    #region ToYesNo

    [Fact]
    public void ToYesNo_True_Yes() => Assert.Equal("Yes", true.ToYesNo());

    [Fact]
    public void ToYesNo_False_No() => Assert.Equal("No", false.ToYesNo());

    #endregion

    #region ToYN

    [Fact]
    public void ToYN_True_Y() => Assert.Equal("Y", true.ToYN());

    [Fact]
    public void ToYN_False_N() => Assert.Equal("N", false.ToYN());

    #endregion
}