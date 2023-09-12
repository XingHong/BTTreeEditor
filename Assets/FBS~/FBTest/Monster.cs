// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FBTest
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct Monster : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static Monster GetRootAsMonster(ByteBuffer _bb) { return GetRootAsMonster(_bb, new Monster()); }
  public static Monster GetRootAsMonster(ByteBuffer _bb, Monster obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Monster __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FBTest.Monster> CreateMonster(FlatBufferBuilder builder,
      int id = 0) {
    builder.StartTable(1);
    Monster.AddId(builder, id);
    return Monster.EndMonster(builder);
  }

  public static void StartMonster(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static Offset<FBTest.Monster> EndMonster(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FBTest.Monster>(o);
  }
  public MonsterT UnPack() {
    var _o = new MonsterT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MonsterT _o) {
    _o.Id = this.Id;
  }
  public static Offset<FBTest.Monster> Pack(FlatBufferBuilder builder, MonsterT _o) {
    if (_o == null) return default(Offset<FBTest.Monster>);
    return CreateMonster(
      builder,
      _o.Id);
  }
}

public class MonsterT
{
  public int Id { get; set; }

  public MonsterT() {
    this.Id = 0;
  }
}


static public class MonsterVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
