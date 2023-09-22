// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Royal.Scenes.Game.Utils.FlatLevel
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FTiledSetMaxItemCount : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static FTiledSetMaxItemCount GetRootAsFTiledSetMaxItemCount(ByteBuffer _bb) { return GetRootAsFTiledSetMaxItemCount(_bb, new FTiledSetMaxItemCount()); }
  public static FTiledSetMaxItemCount GetRootAsFTiledSetMaxItemCount(ByteBuffer _bb, FTiledSetMaxItemCount obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FTiledSetMaxItemCount __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MaxCount { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSetMaxItemCount> CreateFTiledSetMaxItemCount(FlatBufferBuilder builder,
      int Id = 0,
      int MaxCount = 0) {
    builder.StartTable(2);
    FTiledSetMaxItemCount.AddMaxCount(builder, MaxCount);
    FTiledSetMaxItemCount.AddId(builder, Id);
    return FTiledSetMaxItemCount.EndFTiledSetMaxItemCount(builder);
  }

  public static void StartFTiledSetMaxItemCount(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddMaxCount(FlatBufferBuilder builder, int maxCount) { builder.AddInt(1, maxCount, 0); }
  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSetMaxItemCount> EndFTiledSetMaxItemCount(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSetMaxItemCount>(o);
  }
  public FTiledSetMaxItemCountT UnPack() {
    var _o = new FTiledSetMaxItemCountT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FTiledSetMaxItemCountT _o) {
    _o.Id = this.Id;
    _o.MaxCount = this.MaxCount;
  }
  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSetMaxItemCount> Pack(FlatBufferBuilder builder, FTiledSetMaxItemCountT _o) {
    if (_o == null) return default(Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSetMaxItemCount>);
    return CreateFTiledSetMaxItemCount(
      builder,
      _o.Id,
      _o.MaxCount);
  }
}

public class FTiledSetMaxItemCountT
{
  public int Id { get; set; }
  public int MaxCount { get; set; }

  public FTiledSetMaxItemCountT() {
    this.Id = 0;
    this.MaxCount = 0;
  }
}


static public class FTiledSetMaxItemCountVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*MaxCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
