// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Royal.Scenes.Game.Utils.FlatLevel
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FBlindsGroupData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static FBlindsGroupData GetRootAsFBlindsGroupData(ByteBuffer _bb) { return GetRootAsFBlindsGroupData(_bb, new FBlindsGroupData()); }
  public static FBlindsGroupData GetRootAsFBlindsGroupData(ByteBuffer _bb, FBlindsGroupData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FBlindsGroupData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Width { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public Royal.Scenes.Game.Utils.FlatLevel.FMagnetPoint? MagnetCells(int j) { int o = __p.__offset(6); return o != 0 ? (Royal.Scenes.Game.Utils.FlatLevel.FMagnetPoint?)(new Royal.Scenes.Game.Utils.FlatLevel.FMagnetPoint()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int MagnetCellsLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FBlindsGroupData> CreateFBlindsGroupData(FlatBufferBuilder builder,
      int Width = 0,
      VectorOffset MagnetCellsOffset = default(VectorOffset)) {
    builder.StartTable(2);
    FBlindsGroupData.AddMagnetCells(builder, MagnetCellsOffset);
    FBlindsGroupData.AddWidth(builder, Width);
    return FBlindsGroupData.EndFBlindsGroupData(builder);
  }

  public static void StartFBlindsGroupData(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddWidth(FlatBufferBuilder builder, int width) { builder.AddInt(0, width, 0); }
  public static void AddMagnetCells(FlatBufferBuilder builder, VectorOffset magnetCellsOffset) { builder.AddOffset(1, magnetCellsOffset.Value, 0); }
  public static VectorOffset CreateMagnetCellsVector(FlatBufferBuilder builder, Offset<Royal.Scenes.Game.Utils.FlatLevel.FMagnetPoint>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateMagnetCellsVectorBlock(FlatBufferBuilder builder, Offset<Royal.Scenes.Game.Utils.FlatLevel.FMagnetPoint>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMagnetCellsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Royal.Scenes.Game.Utils.FlatLevel.FMagnetPoint>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMagnetCellsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<Royal.Scenes.Game.Utils.FlatLevel.FMagnetPoint>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMagnetCellsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FBlindsGroupData> EndFBlindsGroupData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Royal.Scenes.Game.Utils.FlatLevel.FBlindsGroupData>(o);
  }
  public FBlindsGroupDataT UnPack() {
    var _o = new FBlindsGroupDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FBlindsGroupDataT _o) {
    _o.Width = this.Width;
    _o.MagnetCells = new List<Royal.Scenes.Game.Utils.FlatLevel.FMagnetPointT>();
    for (var _j = 0; _j < this.MagnetCellsLength; ++_j) {_o.MagnetCells.Add(this.MagnetCells(_j).HasValue ? this.MagnetCells(_j).Value.UnPack() : null);}
  }
  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FBlindsGroupData> Pack(FlatBufferBuilder builder, FBlindsGroupDataT _o) {
    if (_o == null) return default(Offset<Royal.Scenes.Game.Utils.FlatLevel.FBlindsGroupData>);
    var _MagnetCells = default(VectorOffset);
    if (_o.MagnetCells != null) {
      var __MagnetCells = new Offset<Royal.Scenes.Game.Utils.FlatLevel.FMagnetPoint>[_o.MagnetCells.Count];
      for (var _j = 0; _j < __MagnetCells.Length; ++_j) { __MagnetCells[_j] = Royal.Scenes.Game.Utils.FlatLevel.FMagnetPoint.Pack(builder, _o.MagnetCells[_j]); }
      _MagnetCells = CreateMagnetCellsVector(builder, __MagnetCells);
    }
    return CreateFBlindsGroupData(
      builder,
      _o.Width,
      _MagnetCells);
  }
}

public class FBlindsGroupDataT
{
  [Newtonsoft.Json.JsonProperty("Width")]
  public int Width { get; set; }
  [Newtonsoft.Json.JsonProperty("MagnetCells")]
  public List<Royal.Scenes.Game.Utils.FlatLevel.FMagnetPointT> MagnetCells { get; set; }

  public FBlindsGroupDataT() {
    this.Width = 0;
    this.MagnetCells = null;
  }
}


static public class FBlindsGroupDataVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Width*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfTables(tablePos, 6 /*MagnetCells*/, Royal.Scenes.Game.Utils.FlatLevel.FMagnetPointVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}