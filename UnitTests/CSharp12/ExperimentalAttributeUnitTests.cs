using Features.CSharp12.ExperimentalAttributeFeature;

namespace UnitTests.CSharp12;

public class ExperimentalAttributeUnitTests
{
	[Fact]
	public void RecordType_Equality_Records_Are_Equal()
	{
		// uncommenting the line below will show red squggles indicating NewFeatureForMyApp type   
		//  "...is for evaluation purposes only and is subject to change or removal in future updates. 
		//  Surpress this diagnostic to proceed."
#pragma warning disable NewFeature
		NewFeatureForMyApp newFeature = new NewFeatureForMyApp();

		Assert.Equal(typeof(NewFeatureForMyApp), newFeature.GetType());
#pragma warning restore NewFeature
	}
}
