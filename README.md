 [nuget-url]: https://www.nuget.org/packages/GON.BitExtensions/

# GON.BitExtensions

## What is does?

.NET Extensions to simplify work with bits


## Nuget Package

[NuGet package link][nuget-url]


## Examples

```csharp
byte b = 0x0F;

b = b.SetBit(4); //Base is Zero
//b == 0b00011111

b = b.ClearBit(1); //Base is Zero
//b == 0b00011101

b = b.ToggleBit(1); //Base is Zero
//b == 0b00011111
b = b.ToggleBit(1); //Base is Zero
//b == 0b00011101

b = b.ChangeBit(0, true); //Base is Zero
b = b.ChangeBit(1, true); //Base is Zero
//b == 0b00011111

bool flag = b.IsBitSet(1);
//flag == true
```


