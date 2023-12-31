// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Royal.Scenes.Game.Utils.FlatLevel
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FCellGroupData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static FCellGroupData GetRootAsFCellGroupData(ByteBuffer _bb) { return GetRootAsFCellGroupData(_bb, new FCellGroupData()); }
  public static FCellGroupData GetRootAsFCellGroupData(ByteBuffer _bb, FCellGroupData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FCellGroupData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Royal.Scenes.Game.Utils.FlatLevel.FPoint? Cells(int j) { int o = __p.__offset(4); return o != 0 ? (Royal.Scenes.Game.Utils.FlatLevel.FPoint?)(new Royal.Scenes.Game.Utils.FlatLevel.FPoint()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int CellsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData> CreateFCellGroupData(FlatBufferBuilder builder,
      VectorOffset CellsOffset = default(VectorOffset)) {
    builder.StartTable(1);
    FCellGroupData.AddCells(builder, CellsOffset);
    return FCellGroupData.EndFCellGroupData(builder);
  }

  public static void StartFCellGroupData(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddCells(FlatBufferBuilder builder, VectorOffset cellsOffset) { builder.AddOffset(0, cellsOffset.Value, 0); }
  public static VectorOffset CreateCellsVector(FlatBufferBuilder builder, Offset<Royal.Scenes.Game.Utils.FlatLevel.FPoint>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateCellsVectorBlock(FlatBufferBuilder builder, Offset<Royal.Scenes.Game.Utils.FlatLevel.FPoint>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCellsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Royal.Scenes.Game.Utils.FlatLevel.FPoint>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCellsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<Royal.Scenes.Game.Utils.FlatLevel.FPoint>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCellsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData> EndFCellGroupData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData>(o);
  }
  public FCellGroupDataT UnPack() {
    var _o = new FCellGroupDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FCellGroupDataT _o) {
    _o.Cells = new List<Royal.Scenes.Game.Utils.FlatLevel.FPointT>();
    for (var _j = 0; _j < this.CellsLength; ++_j) {_o.Cells.Add(this.Cells(_j).HasValue ? this.Cells(_j).Value.UnPack() : null);}
  }
  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData> Pack(FlatBufferBuilder builder, FCellGroupDataT _o) {
    if (_o == null) return default(Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData>);
    var _Cells = default(VectorOffset);
    if (_o.Cells != null) {
      var __Cells = new Offset<Royal.Scenes.Game.Utils.FlatLevel.FPoint>[_o.Cells.Count];
      for (var _j = 0; _j < __Cells.Length; ++_j) { __Cells[_j] = Royal.Scenes.Game.Utils.FlatLevel.FPoint.Pack(builder, _o.Cells[_j]); }
      _Cells = CreateCellsVector(builder, __Cells);
    }
    return CreateFCellGroupData(
      builder,
      _Cells);
  }
}

public class FCellGroupDataT
{
  public List<Royal.Scenes.Game.Utils.FlatLevel.FPointT> Cells { get; set; }

  public FCellGroupDataT() {
    this.Cells = null;
  }
}


static public class FCellGroupDataVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*Cells*/, Royal.Scenes.Game.Utils.FlatLevel.FPointVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
