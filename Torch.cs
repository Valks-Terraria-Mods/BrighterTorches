namespace BrighterTorches;

public class Torch : GlobalTile
{
    public override void ModifyLight(int i, int j, int type, ref float r, ref float g, ref float b){
        if (type == TileID.Torches) {
            r += 0.5f;
        }
    }
}
