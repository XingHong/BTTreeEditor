// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Royal.Scenes.Game.Utils.FlatLevel
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FSlotConfig : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static FSlotConfig GetRootAsFSlotConfig(ByteBuffer _bb) { return GetRootAsFSlotConfig(_bb, new FSlotConfig()); }
  public static FSlotConfig GetRootAsFSlotConfig(ByteBuffer _bb, FSlotConfig obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FSlotConfig __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int StartIndex { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool HasLightball { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool HasRocket { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool HasTnt { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool HasPropeller { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FSlotConfig> CreateFSlotConfig(FlatBufferBuilder builder,
      int StartIndex = 0,
      bool HasLightball = false,
      bool HasRocket = false,
      bool HasTnt = false,
      bool HasPropeller = false) {
    builder.StartTable(5);
    FSlotConfig.AddStartIndex(builder, StartIndex);
    FSlotConfig.AddHasPropeller(builder, HasPropeller);
    FSlotConfig.AddHasTnt(builder, HasTnt);
    FSlotConfig.AddHasRocket(builder, HasRocket);
    FSlotConfig.AddHasLightball(builder, HasLightball);
    return FSlotConfig.EndFSlotConfig(builder);
  }

  public static void StartFSlotConfig(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddStartIndex(FlatBufferBuilder builder, int startIndex) { builder.AddInt(0, startIndex, 0); }
  public static void AddHasLightball(FlatBufferBuilder builder, bool hasLightball) { builder.AddBool(1, hasLightball, false); }
  public static void AddHasRocket(FlatBufferBuilder builder, bool hasRocket) { builder.AddBool(2, hasRocket, false); }
  public static void AddHasTnt(FlatBufferBuilder builder, bool hasTnt) { builder.AddBool(3, hasTnt, false); }
  public static void AddHasPropeller(FlatBufferBuilder builder, bool hasPropeller) { builder.AddBool(4, hasPropeller, false); }
  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FSlotConfig> EndFSlotConfig(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Royal.Scenes.Game.Utils.FlatLevel.FSlotConfig>(o);
  }
  public FSlotConfigT UnPack() {
    var _o = new FSlotConfigT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FSlotConfigT _o) {
    _o.StartIndex = this.StartIndex;
    _o.HasLightball = this.HasLightball;
    _o.HasRocket = this.HasRocket;
    _o.HasTnt = this.HasTnt;
    _o.HasPropeller = this.HasPropeller;
  }
  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FSlotConfig> Pack(FlatBufferBuilder builder, FSlotConfigT _o) {
    if (_o == null) return default(Offset<Royal.Scenes.Game.Utils.FlatLevel.FSlotConfig>);
    return CreateFSlotConfig(
      builder,
      _o.StartIndex,
      _o.HasLightball,
      _o.HasRocket,
      _o.HasTnt,
      _o.HasPropeller);
  }
}

public class FSlotConfigT
{
  [Newtonsoft.Json.JsonProperty("StartIndex")]
  public int StartIndex { get; set; }
  [Newtonsoft.Json.JsonProperty("HasLightball")]
  public bool HasLightball { get; set; }
  [Newtonsoft.Json.JsonProperty("HasRocket")]
  public bool HasRocket { get; set; }
  [Newtonsoft.Json.JsonProperty("HasTnt")]
  public bool HasTnt { get; set; }
  [Newtonsoft.Json.JsonProperty("HasPropeller")]
  public bool HasPropeller { get; set; }

  public FSlotConfigT() {
    this.StartIndex = 0;
    this.HasLightball = false;
    this.HasRocket = false;
    this.HasTnt = false;
    this.HasPropeller = false;
  }
}


static public class FSlotConfigVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*StartIndex*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*HasLightball*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 8 /*HasRocket*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 10 /*HasTnt*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 12 /*HasPropeller*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
