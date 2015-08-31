/**
 * Autogenerated by Thrift Compiler (0.9.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;


/// <summary>
/// A TRegionInfo contains information about an HTable region.
/// </summary>
#if !SILVERLIGHT
[Serializable]
#endif
public partial class TRegionInfo : TBase
{
  private byte[] _startKey;
  private byte[] _endKey;
  private long _id;
  private byte[] _name;
  private byte _version;
  private byte[] _serverName;
  private int _port;

  public byte[] StartKey
  {
    get
    {
      return _startKey;
    }
    set
    {
      __isset.startKey = true;
      this._startKey = value;
    }
  }

  public byte[] EndKey
  {
    get
    {
      return _endKey;
    }
    set
    {
      __isset.endKey = true;
      this._endKey = value;
    }
  }

  public long Id
  {
    get
    {
      return _id;
    }
    set
    {
      __isset.id = true;
      this._id = value;
    }
  }

  public byte[] Name
  {
    get
    {
      return _name;
    }
    set
    {
      __isset.name = true;
      this._name = value;
    }
  }

  public byte Version
  {
    get
    {
      return _version;
    }
    set
    {
      __isset.version = true;
      this._version = value;
    }
  }

  public byte[] ServerName
  {
    get
    {
      return _serverName;
    }
    set
    {
      __isset.serverName = true;
      this._serverName = value;
    }
  }

  public int Port
  {
    get
    {
      return _port;
    }
    set
    {
      __isset.port = true;
      this._port = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool startKey;
    public bool endKey;
    public bool id;
    public bool name;
    public bool version;
    public bool serverName;
    public bool port;
  }

  public TRegionInfo() {
  }

  public void Read (TProtocol iprot)
  {
    TField field;
    iprot.ReadStructBegin();
    while (true)
    {
      field = iprot.ReadFieldBegin();
      if (field.Type == TType.Stop) { 
        break;
      }
      switch (field.ID)
      {
        case 1:
          if (field.Type == TType.String) {
            StartKey = iprot.ReadBinary();
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 2:
          if (field.Type == TType.String) {
            EndKey = iprot.ReadBinary();
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 3:
          if (field.Type == TType.I64) {
            Id = iprot.ReadI64();
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 4:
          if (field.Type == TType.String) {
            Name = iprot.ReadBinary();
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 5:
          if (field.Type == TType.Byte) {
            Version = (byte)iprot.ReadByte();
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 6:
          if (field.Type == TType.String) {
            ServerName = iprot.ReadBinary();
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 7:
          if (field.Type == TType.I32) {
            Port = iprot.ReadI32();
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        default: 
          TProtocolUtil.Skip(iprot, field.Type);
          break;
      }
      iprot.ReadFieldEnd();
    }
    iprot.ReadStructEnd();
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("TRegionInfo");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    if (StartKey != null && __isset.startKey) {
      field.Name = "startKey";
      field.Type = TType.String;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteBinary(StartKey);
      oprot.WriteFieldEnd();
    }
    if (EndKey != null && __isset.endKey) {
      field.Name = "endKey";
      field.Type = TType.String;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      oprot.WriteBinary(EndKey);
      oprot.WriteFieldEnd();
    }
    if (__isset.id) {
      field.Name = "id";
      field.Type = TType.I64;
      field.ID = 3;
      oprot.WriteFieldBegin(field);
      oprot.WriteI64(Id);
      oprot.WriteFieldEnd();
    }
    if (Name != null && __isset.name) {
      field.Name = "name";
      field.Type = TType.String;
      field.ID = 4;
      oprot.WriteFieldBegin(field);
      oprot.WriteBinary(Name);
      oprot.WriteFieldEnd();
    }
    if (__isset.version) {
      field.Name = "version";
      field.Type = TType.Byte;
      field.ID = 5;
      oprot.WriteFieldBegin(field);
      oprot.WriteByte((sbyte)Version);
      oprot.WriteFieldEnd();
    }
    if (ServerName != null && __isset.serverName) {
      field.Name = "serverName";
      field.Type = TType.String;
      field.ID = 6;
      oprot.WriteFieldBegin(field);
      oprot.WriteBinary(ServerName);
      oprot.WriteFieldEnd();
    }
    if (__isset.port) {
      field.Name = "port";
      field.Type = TType.I32;
      field.ID = 7;
      oprot.WriteFieldBegin(field);
      oprot.WriteI32(Port);
      oprot.WriteFieldEnd();
    }
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder sb = new StringBuilder("TRegionInfo(");
    sb.Append("StartKey: ");
    sb.Append(StartKey);
    sb.Append(",EndKey: ");
    sb.Append(EndKey);
    sb.Append(",Id: ");
    sb.Append(Id);
    sb.Append(",Name: ");
    sb.Append(Name);
    sb.Append(",Version: ");
    sb.Append(Version);
    sb.Append(",ServerName: ");
    sb.Append(ServerName);
    sb.Append(",Port: ");
    sb.Append(Port);
    sb.Append(")");
    return sb.ToString();
  }

}
