using System.Collections.Generic;

namespace Configurator.Models
 {
    public class StoreFeatureOption
    {
        public string edition {get;set;}
        public string availability {get;set;}
    }

    public class StoreFeature
    {
        public bool isModule {get; set;}
        public string description {get;set;}
        public string fragment {get;set;}
        public List<StoreFeatureOption> options {get;set;} = new List<StoreFeatureOption>();
    }

    public class StoreConfiguration
    {
        public string name {get; set;}
        public List<StoreFeature> features { get; set; } = new List<StoreFeature>();
    }
 }