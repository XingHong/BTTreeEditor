// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Royal.Scenes.Game.Utils.FlatLevel
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FPotionColor : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static FPotionColor GetRootAsFPotionColor(ByteBuffer _bb) { return GetRootAsFPotionColor(_bb, new FPotionColor()); }
  public static FPotionColor GetRootAsFPotionColor(ByteBuffer _bb, FPotionColor obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FPotionColor __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Colors(int j) { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ColorsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetColorsBytes() { return __p.__vector_as_span<int>(4, 4); }
#else
  public ArraySegment<byte>? GetColorsBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public int[] GetColorsArray() { return __p.__vector_as_array<int>(4); }

  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FPotionColor> CreateFPotionColor(FlatBufferBuilder builder,
      VectorOffset ColorsOffset = default(VectorOffset)) {
    builder.StartTable(1);
    FPotionColor.AddColors(builder, ColorsOffset);
    return FPotionColor.EndFPotionColor(builder);
  }

  public static void StartFPotionColor(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddColors(FlatBufferBuilder builder, VectorOffset colorsOffset) { builder.AddOffset(0, colorsOffset.Value, 0); }
  public static VectorOffset CreateColorsVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateColorsVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateColorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateColorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartColorsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FPotionColor> EndFPotionColor(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Royal.Scenes.Game.Utils.FlatLevel.FPotionColor>(o);
  }
  public FPotionColorT UnPack() {
    var _o = new FPotionColorT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FPotionColorT _o) {
    _o.Colors = new List<int>();
    for (var _j = 0; _j < this.ColorsLength; ++_j) {_o.Colors.Add(this.Colors(_j));}
  }
  public static Offset<Royal.Scenes.Game.Utils.FlatLevel.FPotionColor> Pack(FlatBufferBuilder builder, FPotionColorT _o) {
    if (_o == null) return default(Offset<Royal.Scenes.Game.Utils.FlatLevel.FPotionColor>);
    var _Colors = default(VectorOffset);
    if (_o.Colors != null) {
      var __Colors = _o.Colors.ToArray();
      _Colors = CreateColorsVector(builder, __Colors);
    }
    return CreateFPotionColor(
      builder,
      _Colors);
  }
}

public class FPotionColorT
{
  [Newtonsoft.Json.JsonProperty("Colors")]
  public List<int> Colors { get; set; }

  public FPotionColorT() {
    this.Colors = null;
  }
}


static public class FPotionColorVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfData(tablePos, 4 /*Colors*/, 4 /*int*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
