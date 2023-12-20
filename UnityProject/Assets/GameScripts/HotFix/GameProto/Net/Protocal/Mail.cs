// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: mail.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from mail.proto</summary>
public static partial class MailReflection {

  #region Descriptor
  /// <summary>File descriptor for mail.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static MailReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CgptYWlsLnByb3RvGgpiZWFuLnByb3RvIg0KC01haWxMaXN0UmVxIiUKDE1h",
          "aWxMaXN0UmVzcBIVCgRtYWlsGAEgAygLMgcuTWFpbFBiIicKC01haWxPcGVy",
          "UmVxEgoKAmlkGAEgASgFEgwKBG9wZXIYAiABKAUiKQoMTWFpbE9wZXJSZXNw",
          "EgoKAmlkGAEgASgFEg0KBXN0YXRlGAIgASgFQhQKCmNvbS5jYi5tc2dCBlBC",
          "TWFpbGIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::BeanReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::MailListReq), global::MailListReq.Parser, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::MailListResp), global::MailListResp.Parser, new[]{ "Mail" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::MailOperReq), global::MailOperReq.Parser, new[]{ "Id", "Oper" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::MailOperResp), global::MailOperResp.Parser, new[]{ "Id", "State" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
///邮件列表请求
/// </summary>
public sealed partial class MailListReq : pb::IMessage<MailListReq> {
  private static readonly pb::MessageParser<MailListReq> _parser = new pb::MessageParser<MailListReq>(() => new MailListReq());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<MailListReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MailReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MailListReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MailListReq(MailListReq other) : this() {
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MailListReq Clone() {
    return new MailListReq(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as MailListReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(MailListReq other) {
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
  public void MergeFrom(MailListReq other) {
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

public sealed partial class MailListResp : pb::IMessage<MailListResp> {
  private static readonly pb::MessageParser<MailListResp> _parser = new pb::MessageParser<MailListResp>(() => new MailListResp());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<MailListResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MailReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MailListResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MailListResp(MailListResp other) : this() {
    mail_ = other.mail_.Clone();
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MailListResp Clone() {
    return new MailListResp(this);
  }

  /// <summary>Field number for the "mail" field.</summary>
  public const int MailFieldNumber = 1;
  private static readonly pb::FieldCodec<global::MailPb> _repeated_mail_codec
      = pb::FieldCodec.ForMessage(10, global::MailPb.Parser);
  private readonly pbc::RepeatedField<global::MailPb> mail_ = new pbc::RepeatedField<global::MailPb>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::MailPb> Mail {
    get { return mail_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as MailListResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(MailListResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!mail_.Equals(other.mail_)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= mail_.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    mail_.WriteTo(output, _repeated_mail_codec);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += mail_.CalculateSize(_repeated_mail_codec);
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(MailListResp other) {
    if (other == null) {
      return;
    }
    mail_.Add(other.mail_);
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
          mail_.AddEntriesFrom(input, _repeated_mail_codec);
          break;
        }
      }
    }
  }

}

/// <summary>
///邮件操作
/// </summary>
public sealed partial class MailOperReq : pb::IMessage<MailOperReq> {
  private static readonly pb::MessageParser<MailOperReq> _parser = new pb::MessageParser<MailOperReq>(() => new MailOperReq());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<MailOperReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MailReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MailOperReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MailOperReq(MailOperReq other) : this() {
    id_ = other.id_;
    oper_ = other.oper_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MailOperReq Clone() {
    return new MailOperReq(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 1;
  private int id_;
  /// <summary>
  ///邮件id
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  /// <summary>Field number for the "oper" field.</summary>
  public const int OperFieldNumber = 2;
  private int oper_;
  /// <summary>
  ///操作 1-读取 2-领附件 3-删除
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Oper {
    get { return oper_; }
    set {
      oper_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as MailOperReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(MailOperReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    if (Oper != other.Oper) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Id != 0) hash ^= Id.GetHashCode();
    if (Oper != 0) hash ^= Oper.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Id != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Id);
    }
    if (Oper != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Oper);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Id != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
    }
    if (Oper != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Oper);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(MailOperReq other) {
    if (other == null) {
      return;
    }
    if (other.Id != 0) {
      Id = other.Id;
    }
    if (other.Oper != 0) {
      Oper = other.Oper;
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
        case 8: {
          Id = input.ReadInt32();
          break;
        }
        case 16: {
          Oper = input.ReadInt32();
          break;
        }
      }
    }
  }

}

public sealed partial class MailOperResp : pb::IMessage<MailOperResp> {
  private static readonly pb::MessageParser<MailOperResp> _parser = new pb::MessageParser<MailOperResp>(() => new MailOperResp());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<MailOperResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MailReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MailOperResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MailOperResp(MailOperResp other) : this() {
    id_ = other.id_;
    state_ = other.state_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MailOperResp Clone() {
    return new MailOperResp(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 1;
  private int id_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  /// <summary>Field number for the "state" field.</summary>
  public const int StateFieldNumber = 2;
  private int state_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int State {
    get { return state_; }
    set {
      state_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as MailOperResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(MailOperResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    if (State != other.State) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Id != 0) hash ^= Id.GetHashCode();
    if (State != 0) hash ^= State.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Id != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Id);
    }
    if (State != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(State);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Id != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
    }
    if (State != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(State);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(MailOperResp other) {
    if (other == null) {
      return;
    }
    if (other.Id != 0) {
      Id = other.Id;
    }
    if (other.State != 0) {
      State = other.State;
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
        case 8: {
          Id = input.ReadInt32();
          break;
        }
        case 16: {
          State = input.ReadInt32();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
