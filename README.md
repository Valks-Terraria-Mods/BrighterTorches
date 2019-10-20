All torches are 50% brighter / red.

```cs
public override void ModifyLight(int i, int j, int type, ref float r, ref float g, ref float b){
    if (type == TileID.Torches) {
        r += 0.5f;
    }
}
```
