// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Royal.Scenes.Game.Utils.FlatLevel
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FTiledGrid : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static FTiledGrid GetRootAsFTiledGrid(ByteBuffer _bb) { return GetRootAsFTiledGrid(_bb, new FTiledGrid()); }
  public static FTiledGrid GetRootAsFTiledGrid(ByteBuffer _bb, FTiledGrid obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FTiledGrid __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Items(int j) { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ItemsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetItemsBytes() { return __p.__vector_as_span<int>(4, 4); }
#else
  public ArraySegment<byte>? GetItemsBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public int[] GetItemsArray() { return __p.__vector_as_array<int>(4); }
  public Royal.Scenes.Game.Utils.FlatLevel.FTiledCell? Cells(int j) { int o = __p.__offset(6); return o != 0 ? (Royal.Scenes.Game.Utils.FlatLevel.FTiledCell?)(new Royal.Scenes.Game.Utils.FlatLevel.FTiledCell()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int CellsLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int Width { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Height { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid> CreateFTiledGrid(FlatBufferBuilder builder,
      VectorOffset ItemsOffset = default(VectorOffset),
      VectorOffset CellsOffset = default(VectorOffset),
      int Width = 0,
      int Height = 0) {
    builder.StartTable(4);
    FTiledGrid.AddHeight(builder, Height);
    FTiledGrid.AddWidth(builder, Width);
    FTiledGrid.AddCells(builder, CellsOffset);
    FTiledGrid.AddItems(builder, ItemsOffset);
    return FTiledGrid.EndFTiledGrid(builder);
  }

  public static void StartFTiledGrid(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCells(FlatBufferBuilder builder, VectorOffset cellsOffset) { builder.AddOffset(1, cellsOffset.Value, 0); }
  public static VectorOffset CreateCellsVector(FlatBufferBuilder builder, Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledCell>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateCellsVectorBlock(FlatBufferBuilder builder, Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledCell>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCellsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledCell>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCellsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledCell>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCellsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddWidth(FlatBufferBuilder builder, int width) { builder.AddInt(2, width, 0); }
  public static void AddHeight(FlatBufferBuilder builder, int height) { builder.AddInt(3, height, 0); }
  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid> EndFTiledGrid(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid>(o);
  }
  public FTiledGridT UnPack() {
    var _o = new FTiledGridT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FTiledGridT _o) {
    _o.Items = new List<int>();
    for (var _j = 0; _j < this.ItemsLength; ++_j) {_o.Items.Add(this.Items(_j));}
    _o.Cells = new List<Royal.Scenes.Game.Utils.FlatLevel.FTiledCellT>();
    for (var _j = 0; _j < this.CellsLength; ++_j) {_o.Cells.Add(this.Cells(_j).HasValue ? this.Cells(_j).Value.UnPack() : null);}
    _o.Width = this.Width;
    _o.Height = this.Height;
  }
  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid> Pack(FlatBufferBuilder builder, FTiledGridT _o) {
    if (_o == null) return default(Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid>);
    var _Items = default(VectorOffset);
    if (_o.Items != null) {
      var __Items = _o.Items.ToArray();
      _Items = CreateItemsVector(builder, __Items);
    }
    var _Cells = default(VectorOffset);
    if (_o.Cells != null) {
      var __Cells = new Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledCell>[_o.Cells.Count];
      for (var _j = 0; _j < __Cells.Length; ++_j) { __Cells[_j] = Royal.Scenes.Game.Utils.FlatLevel.FTiledCell.Pack(builder, _o.Cells[_j]); }
      _Cells = CreateCellsVector(builder, __Cells);
    }
    return CreateFTiledGrid(
      builder,
      _Items,
      _Cells,
      _o.Width,
      _o.Height);
  }
}

public class FTiledGridT
{
  public List<int> Items { get; set; }
  public List<Royal.Scenes.Game.Utils.FlatLevel.FTiledCellT> Cells { get; set; }
  public int Width { get; set; }
  public int Height { get; set; }

  public FTiledGridT() {
    this.Items = null;
    this.Cells = null;
    this.Width = 0;
    this.Height = 0;
  }
}


static public class FTiledGridVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfData(tablePos, 4 /*Items*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfTables(tablePos, 6 /*Cells*/, Royal.Scenes.Game.Utils.FlatLevel.FTiledCellVerify.Verify, false)
      && verifier.VerifyField(tablePos, 8 /*Width*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*Height*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
