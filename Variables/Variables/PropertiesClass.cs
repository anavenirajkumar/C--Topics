using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables{
    internal class PropertiesClass {
        int _CustomerId;  // Don't Declare Property start with public keyword
        bool _Status;
        string _CostomerName, _State;
        double _Balance;
        Cities _Cities;

        // Constructor
        public PropertiesClass(int CustomerId, bool Status, string Cname,double Balance, Cities City, string State) {
            _CustomerId = CustomerId;
            _Status = Status;
            _CostomerName = CostomerName;
            _Balance = Balance;
            _Cities = City;
            _State = State;
            //this.Country = Country;

        }

        public int CustomerId { 
         get { return _CustomerId; }
         set { _CustomerId = value; }
        }
        public bool Status { 
         get { return _Status; }
         set { _Status = value;}
            
        }
        public string CostomerName{
            get { return _CostomerName; }
            set { _CostomerName = value; }
        }
        public double Balance {
            get { return _Balance; }
            set{
                if (_Status == true){
                    if (value >= 500){
                        _Balance = value;
                    }
                }
            }
        }
        public Cities City {
            get { return _Cities; }

            set {
                if (_Status == true)
                {
                   _Cities = value;
                }

            }
        }
        public string State {
            get { return _State; }
           protected set { 
               if(_Status == true) {
                    _State = value;
                }
            }
        }
        public string Country
        { // Auto-Implementded or Automatic Property
            get;
            //set;
        } = "India"; // Auto-Property Initializer
        static void Main()
        {

        }
    }

}
