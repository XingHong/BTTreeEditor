// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Royal.Scenes.Game.Utils.FlatLevel
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FLimitData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static FLimitData GetRootAsFLimitData(ByteBuffer _bb) { return GetRootAsFLimitData(_bb, new FLimitData()); }
  public static FLimitData GetRootAsFLimitData(ByteBuffer _bb, FLimitData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FLimitData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Limit { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Count { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int BoardId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FLimitData> CreateFLimitData(FlatBufferBuilder builder,
      int Limit = 0,
      int Count = 0,
      int BoardId = 0) {
    builder.StartTable(3);
    FLimitData.AddBoardId(builder, BoardId);
    FLimitData.AddCount(builder, Count);
    FLimitData.AddLimit(builder, Limit);
    return FLimitData.EndFLimitData(builder);
  }

  public static void StartFLimitData(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddLimit(FlatBufferBuilder builder, int limit) { builder.AddInt(0, limit, 0); }
  public static void AddCount(FlatBufferBuilder builder, int count) { builder.AddInt(1, count, 0); }
  public static void AddBoardId(FlatBufferBuilder builder, int boardId) { builder.AddInt(2, boardId, 0); }
  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FLimitData> EndFLimitData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Royal.Scenes.Game.Utils.FlatLevel.FLimitData>(o);
  }
  public FLimitDataT UnPack() {
    var _o = new FLimitDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FLimitDataT _o) {
    _o.Limit = this.Limit;
    _o.Count = this.Count;
    _o.BoardId = this.BoardId;
  }
  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FLimitData> Pack(FlatBufferBuilder builder, FLimitDataT _o) {
    if (_o == null) return default(Offset<Royal.Scenes.Game.Utils.FlatLevel.FLimitData>);
    return CreateFLimitData(
      builder,
      _o.Limit,
      _o.Count,
      _o.BoardId);
  }
}

public class FLimitDataT
{
  public int Limit { get; set; }
  public int Count { get; set; }
  public int BoardId { get; set; }

  public FLimitDataT() {
    this.Limit = 0;
    this.Count = 0;
    this.BoardId = 0;
  }
}


static public class FLimitDataVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Limit*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Count*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*BoardId*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
