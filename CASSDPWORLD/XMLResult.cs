using System;
using System.IO;
using System.Xml.Serialization;

namespace CASSDPWORLD
{
    class XMLResult
    {
    }


   

    [Serializable]
    [XmlRoot("result")]
    public class Result
    {
        [XmlElement("location")]
        public XmlAttributeWrapper<string> Location { get; set; }

        [XmlElement("cameraid")]
        public XmlAttributeWrapper<string> CameraId { get; set; }

        [XmlElement("ID")]
        public XmlAttributeWrapper<string> Id { get; set; }

        [XmlElement("image_hash")]
        public XmlAttributeWrapper<string> ImageHash { get; set; }

        [XmlElement("capture")]
        public object Capture { get; set; }

        [XmlElement("anpr")]
        public object ANPR { get; set; }

        [XmlElement("adr")]
        public object ADR { get; set; }

        [XmlElement("country")]
        public object Country { get; set; }

        [XmlElement("mmr")]
        public object MMR { get; set; }

        [XmlElement("hyd")]
        public object HYD { get; set; }

        [XmlElement("motdet")]
        public object MOTDET { get; set; }

        [XmlElement("trigger")]
        public object Trigger { get; set; }

        [XmlElement("misc")]
        public object Misc { get; set; }

        [XmlElement("images")]
        public object images { get; set; }
    }

    public class Capture
    {
        [XmlElement("frametime")]
        public XmlAttributeWrapper<string> FrameTime { get; set; }

        [XmlElement("frametimems")]
        public XmlAttributeWrapper<long> FrameTimeMs { get; set; }

        [XmlElement("frameindex")]
        public XmlAttributeWrapper<int> FrameIndex { get; set; }
    }

    public class ANPR
    {
        [XmlElement("text")]
        public XmlAttributeWrapper<string> Text { get; set; }

        [XmlElement("type")]
        public XmlAttributeWrapper<int> Type { get; set; }

        [XmlElement("country")]
        public XmlAttributeWrapper<string> Country { get; set; }

        [XmlElement("state")]
        public XmlAttributeWrapper<string> State { get; set; }

        [XmlElement("frame")]
        public XmlAttributeWrapper<string> Frame { get; set; }

        [XmlElement("bgcolor")]
        public XmlAttributeWrapper<int> BgColor { get; set; }

        [XmlElement("color")]
        public XmlAttributeWrapper<int> Color { get; set; }

        [XmlElement("confidence")]
        public XmlAttributeWrapper<int> Confidence { get; set; }

        [XmlElement("timems")]
        public XmlAttributeWrapper<int> TimeMs { get; set; }

        [XmlElement("resultcnt")]
        public XmlAttributeWrapper<int> ResultCount { get; set; }

        [XmlElement("lpbrg")]
        public XmlAttributeWrapper<int> LpBrg { get; set; }

        [XmlElement("lpsrp")]
        public XmlAttributeWrapper<int> LpSrp { get; set; }

        [XmlElement("opt_speed")]
        public XmlAttributeWrapper<double> OptSpeed { get; set; }

        [XmlElement("category")]
        public XmlAttributeWrapper<string> Category { get; set; }
    }

    // Add similar classes for ADR, Country, MMR, HYD, MOTDET, Trigger, and Misc

    public class XmlAttributeWrapper<T>
    {
        [XmlAttribute("value")]
        public T Value { get; set; }
    }

    

}
