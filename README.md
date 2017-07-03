# Float extension methods for Unity 3D

Simple operations for common float operations

## ExtensionMethods_Float.cs

#### Includes:

- `Smooth0to1` function.
  - pass this function a float in the range of 0–1, and it will return a value blended by the chosen `SmoothType`


- `SmoothType` enum - used to select which `SmoothType` to use when calling the `Smooth0to1` function.
  - **Included smoothing equations:**
    - `SmoothType.smoothstep`
    - `SmoothType.smootherstep`
    - `SmoothType.exponential`
    - `SmoothType.easeOut`
    - `SmoothType.none` — no smoothing applied


## // TODO:

- add additional smoothing equations
- options to incorporate perlin noise to the returned value
- add additional useful float operations
