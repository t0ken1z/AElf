// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: smartcontract.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AElf.SmartContract {

  /// <summary>Holder for reflection information generated from smartcontract.proto</summary>
  public static partial class SmartcontractReflection {

    #region Descriptor
    /// <summary>File descriptor for smartcontract.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SmartcontractReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNzbWFydGNvbnRyYWN0LnByb3RvGgxrZXJuZWwucHJvdG8iQQoIUmVzb3Vy",
            "Y2USDAoETmFtZRgBIAEoCRInCg5EYXRhQWNjZXNzTW9kZRgCIAEoDjIPLkRh",
            "dGFBY2Nlc3NNb2RlIlwKEEZ1bmN0aW9uTWV0YWRhdGESGwoTU2VyaWFsaXpl",
            "Q2FsbGluZ1NldBgBIAMoCRIrChhTZXJpYWxpemVGdWxsUmVzb3VyY2VTZXQY",
            "AiADKAsyCS5SZXNvdXJjZSJCChNTZXJpYWxpemVkQ2FsbEdyYXBoEhkKBUVk",
            "Z2VzGAEgAygLMgouR3JhcGhFZGdlEhAKCFZlcnRpY2VzGAIgAygJIisKCUdy",
            "YXBoRWRnZRIOCgZTb3VyY2UYASABKAkSDgoGVGFyZ2V0GAIgASgJQhWqAhJB",
            "RWxmLlNtYXJ0Q29udHJhY3RiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AElf.Kernel.KernelReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.SmartContract.Resource), global::AElf.SmartContract.Resource.Parser, new[]{ "Name", "DataAccessMode" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.SmartContract.FunctionMetadata), global::AElf.SmartContract.FunctionMetadata.Parser, new[]{ "SerializeCallingSet", "SerializeFullResourceSet" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.SmartContract.SerializedCallGraph), global::AElf.SmartContract.SerializedCallGraph.Parser, new[]{ "Edges", "Vertices" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.SmartContract.GraphEdge), global::AElf.SmartContract.GraphEdge.Parser, new[]{ "Source", "Target" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Resource : pb::IMessage<Resource> {
    private static readonly pb::MessageParser<Resource> _parser = new pb::MessageParser<Resource>(() => new Resource());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Resource> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.SmartContract.SmartcontractReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Resource() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Resource(Resource other) : this() {
      name_ = other.name_;
      dataAccessMode_ = other.dataAccessMode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Resource Clone() {
      return new Resource(this);
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "DataAccessMode" field.</summary>
    public const int DataAccessModeFieldNumber = 2;
    private global::AElf.Kernel.DataAccessMode dataAccessMode_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Kernel.DataAccessMode DataAccessMode {
      get { return dataAccessMode_; }
      set {
        dataAccessMode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Resource);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Resource other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DataAccessMode != other.DataAccessMode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DataAccessMode != 0) hash ^= DataAccessMode.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DataAccessMode != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) DataAccessMode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (DataAccessMode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DataAccessMode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Resource other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DataAccessMode != 0) {
        DataAccessMode = other.DataAccessMode;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            dataAccessMode_ = (global::AElf.Kernel.DataAccessMode) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The function meta data describes the data members of contract object.
  /// </summary>
  public sealed partial class FunctionMetadata : pb::IMessage<FunctionMetadata> {
    private static readonly pb::MessageParser<FunctionMetadata> _parser = new pb::MessageParser<FunctionMetadata>(() => new FunctionMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FunctionMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.SmartContract.SmartcontractReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FunctionMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FunctionMetadata(FunctionMetadata other) : this() {
      serializeCallingSet_ = other.serializeCallingSet_.Clone();
      serializeFullResourceSet_ = other.serializeFullResourceSet_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FunctionMetadata Clone() {
      return new FunctionMetadata(this);
    }

    /// <summary>Field number for the "SerializeCallingSet" field.</summary>
    public const int SerializeCallingSetFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_serializeCallingSet_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> serializeCallingSet_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// AElf allows one contracts to invoke others. This field record
    /// which contracts are invoked by the current contract.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> SerializeCallingSet {
      get { return serializeCallingSet_; }
    }

    /// <summary>Field number for the "SerializeFullResourceSet" field.</summary>
    public const int SerializeFullResourceSetFieldNumber = 2;
    private static readonly pb::FieldCodec<global::AElf.SmartContract.Resource> _repeated_serializeFullResourceSet_codec
        = pb::FieldCodec.ForMessage(18, global::AElf.SmartContract.Resource.Parser);
    private readonly pbc::RepeatedField<global::AElf.SmartContract.Resource> serializeFullResourceSet_ = new pbc::RepeatedField<global::AElf.SmartContract.Resource>();
    /// <summary>
    /// All data members except other contracts are recorded by this field.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::AElf.SmartContract.Resource> SerializeFullResourceSet {
      get { return serializeFullResourceSet_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FunctionMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FunctionMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!serializeCallingSet_.Equals(other.serializeCallingSet_)) return false;
      if(!serializeFullResourceSet_.Equals(other.serializeFullResourceSet_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= serializeCallingSet_.GetHashCode();
      hash ^= serializeFullResourceSet_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      serializeCallingSet_.WriteTo(output, _repeated_serializeCallingSet_codec);
      serializeFullResourceSet_.WriteTo(output, _repeated_serializeFullResourceSet_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += serializeCallingSet_.CalculateSize(_repeated_serializeCallingSet_codec);
      size += serializeFullResourceSet_.CalculateSize(_repeated_serializeFullResourceSet_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FunctionMetadata other) {
      if (other == null) {
        return;
      }
      serializeCallingSet_.Add(other.serializeCallingSet_);
      serializeFullResourceSet_.Add(other.serializeFullResourceSet_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            serializeCallingSet_.AddEntriesFrom(input, _repeated_serializeCallingSet_codec);
            break;
          }
          case 18: {
            serializeFullResourceSet_.AddEntriesFrom(input, _repeated_serializeFullResourceSet_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class SerializedCallGraph : pb::IMessage<SerializedCallGraph> {
    private static readonly pb::MessageParser<SerializedCallGraph> _parser = new pb::MessageParser<SerializedCallGraph>(() => new SerializedCallGraph());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SerializedCallGraph> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.SmartContract.SmartcontractReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SerializedCallGraph() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SerializedCallGraph(SerializedCallGraph other) : this() {
      edges_ = other.edges_.Clone();
      vertices_ = other.vertices_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SerializedCallGraph Clone() {
      return new SerializedCallGraph(this);
    }

    /// <summary>Field number for the "Edges" field.</summary>
    public const int EdgesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::AElf.SmartContract.GraphEdge> _repeated_edges_codec
        = pb::FieldCodec.ForMessage(10, global::AElf.SmartContract.GraphEdge.Parser);
    private readonly pbc::RepeatedField<global::AElf.SmartContract.GraphEdge> edges_ = new pbc::RepeatedField<global::AElf.SmartContract.GraphEdge>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::AElf.SmartContract.GraphEdge> Edges {
      get { return edges_; }
    }

    /// <summary>Field number for the "Vertices" field.</summary>
    public const int VerticesFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_vertices_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> vertices_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Vertices {
      get { return vertices_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SerializedCallGraph);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SerializedCallGraph other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!edges_.Equals(other.edges_)) return false;
      if(!vertices_.Equals(other.vertices_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= edges_.GetHashCode();
      hash ^= vertices_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      edges_.WriteTo(output, _repeated_edges_codec);
      vertices_.WriteTo(output, _repeated_vertices_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += edges_.CalculateSize(_repeated_edges_codec);
      size += vertices_.CalculateSize(_repeated_vertices_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SerializedCallGraph other) {
      if (other == null) {
        return;
      }
      edges_.Add(other.edges_);
      vertices_.Add(other.vertices_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            edges_.AddEntriesFrom(input, _repeated_edges_codec);
            break;
          }
          case 18: {
            vertices_.AddEntriesFrom(input, _repeated_vertices_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GraphEdge : pb::IMessage<GraphEdge> {
    private static readonly pb::MessageParser<GraphEdge> _parser = new pb::MessageParser<GraphEdge>(() => new GraphEdge());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GraphEdge> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.SmartContract.SmartcontractReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GraphEdge() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GraphEdge(GraphEdge other) : this() {
      source_ = other.source_;
      target_ = other.target_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GraphEdge Clone() {
      return new GraphEdge(this);
    }

    /// <summary>Field number for the "Source" field.</summary>
    public const int SourceFieldNumber = 1;
    private string source_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Source {
      get { return source_; }
      set {
        source_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Target" field.</summary>
    public const int TargetFieldNumber = 2;
    private string target_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Target {
      get { return target_; }
      set {
        target_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GraphEdge);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GraphEdge other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Source != other.Source) return false;
      if (Target != other.Target) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Source.Length != 0) hash ^= Source.GetHashCode();
      if (Target.Length != 0) hash ^= Target.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Source.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Source);
      }
      if (Target.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Target);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Source.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Source);
      }
      if (Target.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Target);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GraphEdge other) {
      if (other == null) {
        return;
      }
      if (other.Source.Length != 0) {
        Source = other.Source;
      }
      if (other.Target.Length != 0) {
        Target = other.Target;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Source = input.ReadString();
            break;
          }
          case 18: {
            Target = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
