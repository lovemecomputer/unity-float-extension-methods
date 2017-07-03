using UnityEngine;

public enum SmoothType {none, smoothstep, smootherstep, exponential, easeIn, easeOut};

public static class ExtensionMethods 
{
	// takes 't' and smoothes it.
	public static float Smooth0to1 (this float t, SmoothType smoothType) 
	{
		t = Mathf.Clamp01(t);
		
		switch (smoothType)
		{
			case SmoothType.none:
				break;
			case SmoothType.smoothstep:
				t = t*t * (3f - 2f*t);
				break;
			case SmoothType.smootherstep:
				t = t*t*t * (t * (6f*t - 15f) + 10f);
				break;
			case SmoothType.exponential:
				t = t*t;
				break;
			case SmoothType.easeIn:
				t = 1f - Mathf.Cos(t * Mathf.PI * 0.5f);
				break;
			case SmoothType.easeOut:
				t = Mathf.Sin(t * Mathf.PI * 0.5f);
				break;
		}
		
		return t;
	}

	// quickly remap a float to another range
	public static float RemapToNumberRange (this float value, float lowEndOfRange1, float highEndOfRange1, float lowEndOfRange2, float highEndOfRange2) 
	{
		return (value - lowEndOfRange1) / (highEndOfRange1 - lowEndOfRange1) * (highEndOfRange2 - lowEndOfRange2) + lowEndOfRange2;
	}
}