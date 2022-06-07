[![](https://img.shields.io/static/v1?style=flat-square&logo=discord&logoColor=white&color=blue&label=discord&message=valks%20games)](https://discord.gg/866cg8yfxZ)

All torches are 50% brighter / red.

```cs
public override void ModifyLight(int i, int j, int type, ref float r, ref float g, ref float b){
    if (type == TileID.Torches) {
        r += 0.5f;
    }
}
```
