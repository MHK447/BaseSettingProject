// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace BanpoFri.Data
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct KeyValue : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static KeyValue GetRootAsKeyValue(ByteBuffer _bb) { return GetRootAsKeyValue(_bb, new KeyValue()); }
  public static KeyValue GetRootAsKeyValue(ByteBuffer _bb, KeyValue obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public KeyValue __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool MutateIdx(int idx) { int o = __p.__offset(4); if (o != 0) { __p.bb.PutInt(o + __p.bb_pos, idx); return true; } else { return false; } }
  public float Value { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool MutateValue(float value) { int o = __p.__offset(6); if (o != 0) { __p.bb.PutFloat(o + __p.bb_pos, value); return true; } else { return false; } }

  public static Offset<BanpoFri.Data.KeyValue> CreateKeyValue(FlatBufferBuilder builder,
      int idx = 0,
      float value = 0.0f) {
    builder.StartTable(2);
    KeyValue.AddValue(builder, value);
    KeyValue.AddIdx(builder, idx);
    return KeyValue.EndKeyValue(builder);
  }

  public static void StartKeyValue(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddIdx(FlatBufferBuilder builder, int idx) { builder.AddInt(0, idx, 0); }
  public static void AddValue(FlatBufferBuilder builder, float value) { builder.AddFloat(1, value, 0.0f); }
  public static Offset<BanpoFri.Data.KeyValue> EndKeyValue(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<BanpoFri.Data.KeyValue>(o);
  }
  public KeyValueT UnPack() {
    var _o = new KeyValueT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(KeyValueT _o) {
    _o.Idx = this.Idx;
    _o.Value = this.Value;
  }
  public static Offset<BanpoFri.Data.KeyValue> Pack(FlatBufferBuilder builder, KeyValueT _o) {
    if (_o == null) return default(Offset<BanpoFri.Data.KeyValue>);
    return CreateKeyValue(
      builder,
      _o.Idx,
      _o.Value);
  }
}

public class KeyValueT
{
  [Newtonsoft.Json.JsonProperty("idx")]
  public int Idx { get; set; }
  [Newtonsoft.Json.JsonProperty("value")]
  public float Value { get; set; }

  public KeyValueT() {
    this.Idx = 0;
    this.Value = 0.0f;
  }
}


static public class KeyValueVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Idx*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Value*/, 4 /*float*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
