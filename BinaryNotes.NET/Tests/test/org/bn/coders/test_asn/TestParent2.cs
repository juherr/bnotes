
//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

using System;
using org.bn.attributes;
using org.bn.attributes.constraints;
using org.bn.coders;
using org.bn.types;
using org.bn;

namespace test.org.bn.coders.test_asn {


    [ASN1PreparedElement]
    [ASN1Choice ( Name = "TestParent2") ]
    public class TestParent2 : IASN1PreparedElement {
                    
        
	private long field10_ ;
        private bool  field10_selected = false ;
        
                
        [ASN1Integer( Name = "" )]
    
        [ASN1Element ( Name = "field10", IsOptional =  false , HasTag =  true, Tag = 0 , HasDefaultValue =  false )  ]
    
        public long Field10
        {
            get { return field10_; }
            set { selectField10(value); }
        }
        
                
          
        
	private byte[] field20_ ;
        private bool  field20_selected = false ;
        
                
        [ASN1OctetString( Name = "" )]
    
        [ASN1Element ( Name = "field20", IsOptional =  true , HasTag =  true, Tag = 1 , HasDefaultValue =  false )  ]
    
        public byte[] Field20
        {
            get { return field20_; }
            set { selectField20(value); }
        }
        
                
          
        
	private string field30_ ;
        private bool  field30_selected = false ;
        
                
        [ASN1String( Name = "", 
        StringType =  UniversalTags.UTF8String , IsUCS = false )]
        [ASN1Element ( Name = "field30", IsOptional =  false , HasTag =  true, Tag = 2 , HasDefaultValue =  false )  ]
    
        public string Field30
        {
            get { return field30_; }
            set { selectField30(value); }
        }
        
                
          
        
	private long field40_ ;
        private bool  field40_selected = false ;
        
                
        [ASN1Integer( Name = "" )]
    
        [ASN1Element ( Name = "field40", IsOptional =  false , HasTag =  true, Tag = 3 , HasDefaultValue =  false )  ]
    
        public long Field40
        {
            get { return field40_; }
            set { selectField40(value); }
        }
        
                
          
        public bool isField10Selected () {
            return this.field10_selected ;
        }

        


        public void selectField10 (long val) {
            this.field10_ = val;
            this.field10_selected = true;
            
            
                    this.field20_selected = false;
                
                    this.field30_selected = false;
                
                    this.field40_selected = false;
                            
        }
        
          
        public bool isField20Selected () {
            return this.field20_selected ;
        }

        


        public void selectField20 (byte[] val) {
            this.field20_ = val;
            this.field20_selected = true;
            
            
                    this.field10_selected = false;
                
                    this.field30_selected = false;
                
                    this.field40_selected = false;
                            
        }
        
          
        public bool isField30Selected () {
            return this.field30_selected ;
        }

        


        public void selectField30 (string val) {
            this.field30_ = val;
            this.field30_selected = true;
            
            
                    this.field10_selected = false;
                
                    this.field20_selected = false;
                
                    this.field40_selected = false;
                            
        }
        
          
        public bool isField40Selected () {
            return this.field40_selected ;
        }

        


        public void selectField40 (long val) {
            this.field40_ = val;
            this.field40_selected = true;
            
            
                    this.field10_selected = false;
                
                    this.field20_selected = false;
                
                    this.field30_selected = false;
                            
        }
        
  

            public void initWithDefaults()
	    {
	    }

            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(TestParent2));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

    }
            
}