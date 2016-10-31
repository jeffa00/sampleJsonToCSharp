using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleJsonToCSharp
{

    public class AmazonServices 
    {
        public string formatVersion { get; set; }
        public string disclaimer { get; set; }
        public DateTime publicationDate { get; set; }
        public Offers offers { get; set; }
    }

    public class Offers
    {
        public Amazons3 AmazonS3 { get; set; }
        public Amazonglacier AmazonGlacier { get; set; }
        public Amazonses AmazonSES { get; set; }
        public Amazonrds AmazonRDS { get; set; }
        public Amazonsimpledb AmazonSimpleDB { get; set; }
        public Amazondynamodb AmazonDynamoDB { get; set; }
        public Amazonec2 AmazonEC2 { get; set; }
        public Amazonroute53 AmazonRoute53 { get; set; }
        public Amazonredshift AmazonRedshift { get; set; }
        public Amazonelasticache AmazonElastiCache { get; set; }
        public Amazoncloudfront AmazonCloudFront { get; set; }
        public Awskms awskms { get; set; }
        public Amazonvpc AmazonVPC { get; set; }
    }

    public class Amazons3
    {
        public string offerCode { get; set; }
        public string versionIndexUrl { get; set; }
        public string currentVersionUrl { get; set; }
    }

    public class Amazonglacier
    {
        public string offerCode { get; set; }
        public string versionIndexUrl { get; set; }
        public string currentVersionUrl { get; set; }
    }

    public class Amazonses
    {
        public string offerCode { get; set; }
        public string versionIndexUrl { get; set; }
        public string currentVersionUrl { get; set; }
    }

    public class Amazonrds
    {
        public string offerCode { get; set; }
        public string versionIndexUrl { get; set; }
        public string currentVersionUrl { get; set; }
    }

    public class Amazonsimpledb
    {
        public string offerCode { get; set; }
        public string versionIndexUrl { get; set; }
        public string currentVersionUrl { get; set; }
    }

    public class Amazondynamodb
    {
        public string offerCode { get; set; }
        public string versionIndexUrl { get; set; }
        public string currentVersionUrl { get; set; }
    }

    public class Amazonec2
    {
        public string offerCode { get; set; }
        public string versionIndexUrl { get; set; }
        public string currentVersionUrl { get; set; }
    }

    public class Amazonroute53
    {
        public string offerCode { get; set; }
        public string versionIndexUrl { get; set; }
        public string currentVersionUrl { get; set; }
    }

    public class Amazonredshift
    {
        public string offerCode { get; set; }
        public string versionIndexUrl { get; set; }
        public string currentVersionUrl { get; set; }
    }

    public class Amazonelasticache
    {
        public string offerCode { get; set; }
        public string versionIndexUrl { get; set; }
        public string currentVersionUrl { get; set; }
    }

    public class Amazoncloudfront
    {
        public string offerCode { get; set; }
        public string versionIndexUrl { get; set; }
        public string currentVersionUrl { get; set; }
    }

    public class Awskms
    {
        public string offerCode { get; set; }
        public string versionIndexUrl { get; set; }
        public string currentVersionUrl { get; set; }
    }

    public class Amazonvpc
    {
        public string offerCode { get; set; }
        public string versionIndexUrl { get; set; }
        public string currentVersionUrl { get; set; }
    }

}
