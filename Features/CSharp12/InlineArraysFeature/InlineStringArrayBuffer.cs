namespace Features.CSharp12.InlineArraysFeature;

// this feature was made for the Microsoft team to use by the runtime team
//	it allows the devoper to create a fixed sized struct array

[System.Runtime.CompilerServices.InlineArray(10)]
public struct InlineStringArrayBuffer
{
	private string _element;
}
