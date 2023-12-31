// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Royal.Scenes.Game.Utils.FlatLevel
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FWaterData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static FWaterData GetRootAsFWaterData(ByteBuffer _bb) { return GetRootAsFWaterData(_bb, new FWaterData()); }
  public static FWaterData GetRootAsFWaterData(ByteBuffer _bb, FWaterData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FWaterData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData? EnterPoints { get { int o = __p.__offset(4); return o != 0 ? (Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData?)(new Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData? WaterPoints { get { int o = __p.__offset(6); return o != 0 ? (Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData?)(new Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData? ExitPoints { get { int o = __p.__offset(8); return o != 0 ? (Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData?)(new Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public int WaterReceivableCellCount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int BoardCount { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int SandCellCount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FWaterData> CreateFWaterData(FlatBufferBuilder builder,
      Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData> EnterPointsOffset = default(Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData>),
      Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData> WaterPointsOffset = default(Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData>),
      Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData> ExitPointsOffset = default(Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData>),
      int WaterReceivableCellCount = 0,
      int BoardCount = 0,
      int SandCellCount = 0) {
    builder.StartTable(6);
    FWaterData.AddSandCellCount(builder, SandCellCount);
    FWaterData.AddBoardCount(builder, BoardCount);
    FWaterData.AddWaterReceivableCellCount(builder, WaterReceivableCellCount);
    FWaterData.AddExitPoints(builder, ExitPointsOffset);
    FWaterData.AddWaterPoints(builder, WaterPointsOffset);
    FWaterData.AddEnterPoints(builder, EnterPointsOffset);
    return FWaterData.EndFWaterData(builder);
  }

  public static void StartFWaterData(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddEnterPoints(FlatBufferBuilder builder, Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData> enterPointsOffset) { builder.AddOffset(0, enterPointsOffset.Value, 0); }
  public static void AddWaterPoints(FlatBufferBuilder builder, Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData> waterPointsOffset) { builder.AddOffset(1, waterPointsOffset.Value, 0); }
  public static void AddExitPoints(FlatBufferBuilder builder, Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData> exitPointsOffset) { builder.AddOffset(2, exitPointsOffset.Value, 0); }
  public static void AddWaterReceivableCellCount(FlatBufferBuilder builder, int waterReceivableCellCount) { builder.AddInt(3, waterReceivableCellCount, 0); }
  public static void AddBoardCount(FlatBufferBuilder builder, int boardCount) { builder.AddInt(4, boardCount, 0); }
  public static void AddSandCellCount(FlatBufferBuilder builder, int sandCellCount) { builder.AddInt(5, sandCellCount, 0); }
  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FWaterData> EndFWaterData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Royal.Scenes.Game.Utils.FlatLevel.FWaterData>(o);
  }
  public FWaterDataT UnPack() {
    var _o = new FWaterDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FWaterDataT _o) {
    _o.EnterPoints = this.EnterPoints.HasValue ? this.EnterPoints.Value.UnPack() : null;
    _o.WaterPoints = this.WaterPoints.HasValue ? this.WaterPoints.Value.UnPack() : null;
    _o.ExitPoints = this.ExitPoints.HasValue ? this.ExitPoints.Value.UnPack() : null;
    _o.WaterReceivableCellCount = this.WaterReceivableCellCount;
    _o.BoardCount = this.BoardCount;
    _o.SandCellCount = this.SandCellCount;
  }
  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FWaterData> Pack(FlatBufferBuilder builder, FWaterDataT _o) {
    if (_o == null) return default(Offset<Royal.Scenes.Game.Utils.FlatLevel.FWaterData>);
    var _EnterPoints = _o.EnterPoints == null ? default(Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData>) : Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData.Pack(builder, _o.EnterPoints);
    var _WaterPoints = _o.WaterPoints == null ? default(Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData>) : Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData.Pack(builder, _o.WaterPoints);
    var _ExitPoints = _o.ExitPoints == null ? default(Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData>) : Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData.Pack(builder, _o.ExitPoints);
    return CreateFWaterData(
      builder,
      _EnterPoints,
      _WaterPoints,
      _ExitPoints,
      _o.WaterReceivableCellCount,
      _o.BoardCount,
      _o.SandCellCount);
  }
}

public class FWaterDataT
{
  public Royal.Scenes.Game.Utils.FlatLevel.FCellGroupDataT EnterPoints { get; set; }
  public Royal.Scenes.Game.Utils.FlatLevel.FCellGroupDataT WaterPoints { get; set; }
  public Royal.Scenes.Game.Utils.FlatLevel.FCellGroupDataT ExitPoints { get; set; }
  public int WaterReceivableCellCount { get; set; }
  public int BoardCount { get; set; }
  public int SandCellCount { get; set; }

  public FWaterDataT() {
    this.EnterPoints = null;
    this.WaterPoints = null;
    this.ExitPoints = null;
    this.WaterReceivableCellCount = 0;
    this.BoardCount = 0;
    this.SandCellCount = 0;
  }
}


static public class FWaterDataVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyTable(tablePos, 4 /*EnterPoints*/, Royal.Scenes.Game.Utils.FlatLevel.FCellGroupDataVerify.Verify, false)
      && verifier.VerifyTable(tablePos, 6 /*WaterPoints*/, Royal.Scenes.Game.Utils.FlatLevel.FCellGroupDataVerify.Verify, false)
      && verifier.VerifyTable(tablePos, 8 /*ExitPoints*/, Royal.Scenes.Game.Utils.FlatLevel.FCellGroupDataVerify.Verify, false)
      && verifier.VerifyField(tablePos, 10 /*WaterReceivableCellCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*BoardCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*SandCellCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
