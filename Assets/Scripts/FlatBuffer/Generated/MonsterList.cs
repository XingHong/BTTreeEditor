// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FBTest
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MonsterList : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static MonsterList GetRootAsMonsterList(ByteBuffer _bb) { return GetRootAsMonsterList(_bb, new MonsterList()); }
  public static MonsterList GetRootAsMonsterList(ByteBuffer _bb, MonsterList obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool VerifyMonsterList(ByteBuffer _bb) {Google.FlatBuffers.Verifier verifier = new Google.FlatBuffers.Verifier(_bb); return verifier.VerifyBuffer("", false, MonsterListVerify.Verify); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MonsterList __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FBTest.Monster? List(int j) { int o = __p.__offset(4); return o != 0 ? (FBTest.Monster?)(new FBTest.Monster()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FBTest.MonsterList> CreateMonsterList(FlatBufferBuilder builder,
      VectorOffset listOffset = default(VectorOffset)) {
    builder.StartTable(1);
    MonsterList.AddList(builder, listOffset);
    return MonsterList.EndMonsterList(builder);
  }

  public static void StartMonsterList(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddList(FlatBufferBuilder builder, VectorOffset listOffset) { builder.AddOffset(0, listOffset.Value, 0); }
  public static VectorOffset CreateListVector(FlatBufferBuilder builder, Offset<FBTest.Monster>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateListVectorBlock(FlatBufferBuilder builder, Offset<FBTest.Monster>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FBTest.Monster>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FBTest.Monster>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FBTest.MonsterList> EndMonsterList(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FBTest.MonsterList>(o);
  }
  public static void FinishMonsterListBuffer(FlatBufferBuilder builder, Offset<FBTest.MonsterList> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedMonsterListBuffer(FlatBufferBuilder builder, Offset<FBTest.MonsterList> offset) { builder.FinishSizePrefixed(offset.Value); }
}


static public class MonsterListVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*List*/, FBTest.MonsterVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}