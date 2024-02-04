namespace _28AL.CC.Blocks;

public class BlockTorchHeatMapTE : BlockTorchHeatMap
{
	public override void OnBlockAdded(
			WorldBase _world,
			Chunk _chunk,
			Vector3i _blockPos,
			BlockValue _blockValue)
	{
		base.OnBlockAdded(_world, _chunk, _blockPos, _blockValue);

		if(_blockValue.ischild){
			return;
		}

		if((TileEntityGoreBlock)_world.GetTileEntity(_chunk.ClrIdx, _blockPos) == null){
			TileEntityGoreBlock te = new(_chunk);

			if (te != null) {
				te.localChunkPos = World.toBlock(_blockPos);
				_chunk.AddTileEntity(te);
			}
		}
	}

	public override void OnBlockRemoved(
			WorldBase world,
			Chunk _chunk,
			Vector3i _blockPos,
			BlockValue _blockValue)
	{
		base.OnBlockRemoved(world, _chunk, _blockPos, _blockValue);
		_chunk.RemoveTileEntityAt<TileEntitySign>((World)world, World.toBlock(_blockPos));
	}

	public override DestroyedResult OnBlockDestroyedBy(
			WorldBase _world,
			int _clrIdx,
			Vector3i _blockPos,
			BlockValue _blockValue,
			int _entityId,
			bool _bUseHarvestTool)
	{
		if(_world.GetTileEntity(_clrIdx, _blockPos) is TileEntityGoreBlock teSecureLootContainer) {
			teSecureLootContainer.OnDestroy();
		}

		return DestroyedResult.Downgrade;
	}
}