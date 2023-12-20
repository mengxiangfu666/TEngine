// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: growthFund.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from growthFund.proto</summary>
public static partial class GrowthFundReflection {

  #region Descriptor
  /// <summary>File descriptor for growthFund.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GrowthFundReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChBncm93dGhGdW5kLnByb3RvGgpiZWFuLnByb3RvIjYKFkJ1eURpYW1vZEdy",
          "b3d0aEZ1bmRSZXESHAoUZGlhbW9kR3Jvd3RoRnVuZFRpbWUYASABKAkiGQoX",
          "QnV5RGlhbW9kR3Jvd3RoRnVuZFJlc3AiMgoUQnV5R29sZEdyb3d0aEZ1bmRS",
          "ZXESGgoSZ29sZEdyb3d0aEZ1bmRUaW1lGAEgASgJIhcKFUJ1eUdvbGRHcm93",
          "dGhGdW5kUmVzcCK5AQoZRGlhbW9kR3Jvd3RoRnVuZFJld2FyZFJlcRIpChZk",
          "aWFtb2RHcm93dGhGdW5kUmV3YXJkGAEgASgLMgkuQm9vbExpc3QSPgoKY2hh",
          "bmdlSXRlbRgCIAMoCzIqLkRpYW1vZEdyb3d0aEZ1bmRSZXdhcmRSZXEuQ2hh",
          "bmdlSXRlbUVudHJ5GjEKD0NoYW5nZUl0ZW1FbnRyeRILCgNrZXkYASABKAUS",
          "DQoFdmFsdWUYAiABKAU6AjgBIhwKGkRpYW1vZEdyb3d0aEZ1bmRSZXdhcmRS",
          "ZXNwIrMBChdHb2xkR3Jvd3RoRnVuZFJld2FyZFJlcRInChRnb2xkR3Jvd3Ro",
          "RnVuZFJld2FyZBgBIAEoCzIJLkJvb2xMaXN0EjwKCmNoYW5nZUl0ZW0YAiAD",
          "KAsyKC5Hb2xkR3Jvd3RoRnVuZFJld2FyZFJlcS5DaGFuZ2VJdGVtRW50cnka",
          "MQoPQ2hhbmdlSXRlbUVudHJ5EgsKA2tleRgBIAEoBRINCgV2YWx1ZRgCIAEo",
          "BToCOAEiGgoYR29sZEdyb3d0aEZ1bmRSZXdhcmRSZXNwQhoKCmNvbS5jYi5t",
          "c2dCDFBCR3Jvd3RoRnVuZGIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::BeanReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::BuyDiamodGrowthFundReq), global::BuyDiamodGrowthFundReq.Parser, new[]{ "DiamodGrowthFundTime" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::BuyDiamodGrowthFundResp), global::BuyDiamodGrowthFundResp.Parser, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::BuyGoldGrowthFundReq), global::BuyGoldGrowthFundReq.Parser, new[]{ "GoldGrowthFundTime" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::BuyGoldGrowthFundResp), global::BuyGoldGrowthFundResp.Parser, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::DiamodGrowthFundRewardReq), global::DiamodGrowthFundRewardReq.Parser, new[]{ "DiamodGrowthFundReward", "ChangeItem" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
          new pbr::GeneratedClrTypeInfo(typeof(global::DiamodGrowthFundRewardResp), global::DiamodGrowthFundRewardResp.Parser, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::GoldGrowthFundRewardReq), global::GoldGrowthFundRewardReq.Parser, new[]{ "GoldGrowthFundReward", "ChangeItem" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
          new pbr::GeneratedClrTypeInfo(typeof(global::GoldGrowthFundRewardResp), global::GoldGrowthFundRewardResp.Parser, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
///购买钻石基金
/// </summary>
public sealed partial class BuyDiamodGrowthFundReq : pb::IMessage<BuyDiamodGrowthFundReq> {
  private static readonly pb::MessageParser<BuyDiamodGrowthFundReq> _parser = new pb::MessageParser<BuyDiamodGrowthFundReq>(() => new BuyDiamodGrowthFundReq());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<BuyDiamodGrowthFundReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GrowthFundReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BuyDiamodGrowthFundReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BuyDiamodGrowthFundReq(BuyDiamodGrowthFundReq other) : this() {
    diamodGrowthFundTime_ = other.diamodGrowthFundTime_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BuyDiamodGrowthFundReq Clone() {
    return new BuyDiamodGrowthFundReq(this);
  }

  /// <summary>Field number for the "diamodGrowthFundTime" field.</summary>
  public const int DiamodGrowthFundTimeFieldNumber = 1;
  private string diamodGrowthFundTime_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string DiamodGrowthFundTime {
    get { return diamodGrowthFundTime_; }
    set {
      diamodGrowthFundTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as BuyDiamodGrowthFundReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(BuyDiamodGrowthFundReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (DiamodGrowthFundTime != other.DiamodGrowthFundTime) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (DiamodGrowthFundTime.Length != 0) hash ^= DiamodGrowthFundTime.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (DiamodGrowthFundTime.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(DiamodGrowthFundTime);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (DiamodGrowthFundTime.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(DiamodGrowthFundTime);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(BuyDiamodGrowthFundReq other) {
    if (other == null) {
      return;
    }
    if (other.DiamodGrowthFundTime.Length != 0) {
      DiamodGrowthFundTime = other.DiamodGrowthFundTime;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10: {
          DiamodGrowthFundTime = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class BuyDiamodGrowthFundResp : pb::IMessage<BuyDiamodGrowthFundResp> {
  private static readonly pb::MessageParser<BuyDiamodGrowthFundResp> _parser = new pb::MessageParser<BuyDiamodGrowthFundResp>(() => new BuyDiamodGrowthFundResp());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<BuyDiamodGrowthFundResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GrowthFundReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BuyDiamodGrowthFundResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BuyDiamodGrowthFundResp(BuyDiamodGrowthFundResp other) : this() {
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BuyDiamodGrowthFundResp Clone() {
    return new BuyDiamodGrowthFundResp(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as BuyDiamodGrowthFundResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(BuyDiamodGrowthFundResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(BuyDiamodGrowthFundResp other) {
    if (other == null) {
      return;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
      }
    }
  }

}

/// <summary>
///购买金币基金
/// </summary>
public sealed partial class BuyGoldGrowthFundReq : pb::IMessage<BuyGoldGrowthFundReq> {
  private static readonly pb::MessageParser<BuyGoldGrowthFundReq> _parser = new pb::MessageParser<BuyGoldGrowthFundReq>(() => new BuyGoldGrowthFundReq());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<BuyGoldGrowthFundReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GrowthFundReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BuyGoldGrowthFundReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BuyGoldGrowthFundReq(BuyGoldGrowthFundReq other) : this() {
    goldGrowthFundTime_ = other.goldGrowthFundTime_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BuyGoldGrowthFundReq Clone() {
    return new BuyGoldGrowthFundReq(this);
  }

  /// <summary>Field number for the "goldGrowthFundTime" field.</summary>
  public const int GoldGrowthFundTimeFieldNumber = 1;
  private string goldGrowthFundTime_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string GoldGrowthFundTime {
    get { return goldGrowthFundTime_; }
    set {
      goldGrowthFundTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as BuyGoldGrowthFundReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(BuyGoldGrowthFundReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (GoldGrowthFundTime != other.GoldGrowthFundTime) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (GoldGrowthFundTime.Length != 0) hash ^= GoldGrowthFundTime.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (GoldGrowthFundTime.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(GoldGrowthFundTime);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (GoldGrowthFundTime.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(GoldGrowthFundTime);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(BuyGoldGrowthFundReq other) {
    if (other == null) {
      return;
    }
    if (other.GoldGrowthFundTime.Length != 0) {
      GoldGrowthFundTime = other.GoldGrowthFundTime;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10: {
          GoldGrowthFundTime = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class BuyGoldGrowthFundResp : pb::IMessage<BuyGoldGrowthFundResp> {
  private static readonly pb::MessageParser<BuyGoldGrowthFundResp> _parser = new pb::MessageParser<BuyGoldGrowthFundResp>(() => new BuyGoldGrowthFundResp());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<BuyGoldGrowthFundResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GrowthFundReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BuyGoldGrowthFundResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BuyGoldGrowthFundResp(BuyGoldGrowthFundResp other) : this() {
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BuyGoldGrowthFundResp Clone() {
    return new BuyGoldGrowthFundResp(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as BuyGoldGrowthFundResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(BuyGoldGrowthFundResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(BuyGoldGrowthFundResp other) {
    if (other == null) {
      return;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
      }
    }
  }

}

/// <summary>
///领取钻石基金奖励
/// </summary>
public sealed partial class DiamodGrowthFundRewardReq : pb::IMessage<DiamodGrowthFundRewardReq> {
  private static readonly pb::MessageParser<DiamodGrowthFundRewardReq> _parser = new pb::MessageParser<DiamodGrowthFundRewardReq>(() => new DiamodGrowthFundRewardReq());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<DiamodGrowthFundRewardReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GrowthFundReflection.Descriptor.MessageTypes[4]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public DiamodGrowthFundRewardReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public DiamodGrowthFundRewardReq(DiamodGrowthFundRewardReq other) : this() {
    DiamodGrowthFundReward = other.diamodGrowthFundReward_ != null ? other.DiamodGrowthFundReward.Clone() : null;
    changeItem_ = other.changeItem_.Clone();
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public DiamodGrowthFundRewardReq Clone() {
    return new DiamodGrowthFundRewardReq(this);
  }

  /// <summary>Field number for the "diamodGrowthFundReward" field.</summary>
  public const int DiamodGrowthFundRewardFieldNumber = 1;
  private global::BoolList diamodGrowthFundReward_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::BoolList DiamodGrowthFundReward {
    get { return diamodGrowthFundReward_; }
    set {
      diamodGrowthFundReward_ = value;
    }
  }

  /// <summary>Field number for the "changeItem" field.</summary>
  public const int ChangeItemFieldNumber = 2;
  private static readonly pbc::MapField<int, int>.Codec _map_changeItem_codec
      = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForInt32(16), 18);
  private readonly pbc::MapField<int, int> changeItem_ = new pbc::MapField<int, int>();
  /// <summary>
  ///改变的道具，客户端维护道具
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::MapField<int, int> ChangeItem {
    get { return changeItem_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as DiamodGrowthFundRewardReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(DiamodGrowthFundRewardReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(DiamodGrowthFundReward, other.DiamodGrowthFundReward)) return false;
    if (!ChangeItem.Equals(other.ChangeItem)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (diamodGrowthFundReward_ != null) hash ^= DiamodGrowthFundReward.GetHashCode();
    hash ^= ChangeItem.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (diamodGrowthFundReward_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(DiamodGrowthFundReward);
    }
    changeItem_.WriteTo(output, _map_changeItem_codec);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (diamodGrowthFundReward_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(DiamodGrowthFundReward);
    }
    size += changeItem_.CalculateSize(_map_changeItem_codec);
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(DiamodGrowthFundRewardReq other) {
    if (other == null) {
      return;
    }
    if (other.diamodGrowthFundReward_ != null) {
      if (diamodGrowthFundReward_ == null) {
        diamodGrowthFundReward_ = new global::BoolList();
      }
      DiamodGrowthFundReward.MergeFrom(other.DiamodGrowthFundReward);
    }
    changeItem_.Add(other.changeItem_);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10: {
          if (diamodGrowthFundReward_ == null) {
            diamodGrowthFundReward_ = new global::BoolList();
          }
          input.ReadMessage(diamodGrowthFundReward_);
          break;
        }
        case 18: {
          changeItem_.AddEntriesFrom(input, _map_changeItem_codec);
          break;
        }
      }
    }
  }

}

public sealed partial class DiamodGrowthFundRewardResp : pb::IMessage<DiamodGrowthFundRewardResp> {
  private static readonly pb::MessageParser<DiamodGrowthFundRewardResp> _parser = new pb::MessageParser<DiamodGrowthFundRewardResp>(() => new DiamodGrowthFundRewardResp());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<DiamodGrowthFundRewardResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GrowthFundReflection.Descriptor.MessageTypes[5]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public DiamodGrowthFundRewardResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public DiamodGrowthFundRewardResp(DiamodGrowthFundRewardResp other) : this() {
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public DiamodGrowthFundRewardResp Clone() {
    return new DiamodGrowthFundRewardResp(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as DiamodGrowthFundRewardResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(DiamodGrowthFundRewardResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(DiamodGrowthFundRewardResp other) {
    if (other == null) {
      return;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
      }
    }
  }

}

/// <summary>
///领取金币基金奖励
/// </summary>
public sealed partial class GoldGrowthFundRewardReq : pb::IMessage<GoldGrowthFundRewardReq> {
  private static readonly pb::MessageParser<GoldGrowthFundRewardReq> _parser = new pb::MessageParser<GoldGrowthFundRewardReq>(() => new GoldGrowthFundRewardReq());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<GoldGrowthFundRewardReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GrowthFundReflection.Descriptor.MessageTypes[6]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GoldGrowthFundRewardReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GoldGrowthFundRewardReq(GoldGrowthFundRewardReq other) : this() {
    GoldGrowthFundReward = other.goldGrowthFundReward_ != null ? other.GoldGrowthFundReward.Clone() : null;
    changeItem_ = other.changeItem_.Clone();
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GoldGrowthFundRewardReq Clone() {
    return new GoldGrowthFundRewardReq(this);
  }

  /// <summary>Field number for the "goldGrowthFundReward" field.</summary>
  public const int GoldGrowthFundRewardFieldNumber = 1;
  private global::BoolList goldGrowthFundReward_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::BoolList GoldGrowthFundReward {
    get { return goldGrowthFundReward_; }
    set {
      goldGrowthFundReward_ = value;
    }
  }

  /// <summary>Field number for the "changeItem" field.</summary>
  public const int ChangeItemFieldNumber = 2;
  private static readonly pbc::MapField<int, int>.Codec _map_changeItem_codec
      = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForInt32(16), 18);
  private readonly pbc::MapField<int, int> changeItem_ = new pbc::MapField<int, int>();
  /// <summary>
  ///改变的道具，客户端维护道具
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::MapField<int, int> ChangeItem {
    get { return changeItem_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as GoldGrowthFundRewardReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(GoldGrowthFundRewardReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(GoldGrowthFundReward, other.GoldGrowthFundReward)) return false;
    if (!ChangeItem.Equals(other.ChangeItem)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (goldGrowthFundReward_ != null) hash ^= GoldGrowthFundReward.GetHashCode();
    hash ^= ChangeItem.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (goldGrowthFundReward_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(GoldGrowthFundReward);
    }
    changeItem_.WriteTo(output, _map_changeItem_codec);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (goldGrowthFundReward_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(GoldGrowthFundReward);
    }
    size += changeItem_.CalculateSize(_map_changeItem_codec);
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(GoldGrowthFundRewardReq other) {
    if (other == null) {
      return;
    }
    if (other.goldGrowthFundReward_ != null) {
      if (goldGrowthFundReward_ == null) {
        goldGrowthFundReward_ = new global::BoolList();
      }
      GoldGrowthFundReward.MergeFrom(other.GoldGrowthFundReward);
    }
    changeItem_.Add(other.changeItem_);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10: {
          if (goldGrowthFundReward_ == null) {
            goldGrowthFundReward_ = new global::BoolList();
          }
          input.ReadMessage(goldGrowthFundReward_);
          break;
        }
        case 18: {
          changeItem_.AddEntriesFrom(input, _map_changeItem_codec);
          break;
        }
      }
    }
  }

}

public sealed partial class GoldGrowthFundRewardResp : pb::IMessage<GoldGrowthFundRewardResp> {
  private static readonly pb::MessageParser<GoldGrowthFundRewardResp> _parser = new pb::MessageParser<GoldGrowthFundRewardResp>(() => new GoldGrowthFundRewardResp());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<GoldGrowthFundRewardResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GrowthFundReflection.Descriptor.MessageTypes[7]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GoldGrowthFundRewardResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GoldGrowthFundRewardResp(GoldGrowthFundRewardResp other) : this() {
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GoldGrowthFundRewardResp Clone() {
    return new GoldGrowthFundRewardResp(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as GoldGrowthFundRewardResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(GoldGrowthFundRewardResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(GoldGrowthFundRewardResp other) {
    if (other == null) {
      return;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
      }
    }
  }

}

#endregion


#endregion Designer generated code
