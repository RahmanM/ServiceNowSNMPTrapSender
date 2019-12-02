# SNMP Trap Sender

## Screen
Sends SNMP traps to ServiceNow Event Management. 

[![N|Trap Sender](https://github.com/RahmanM/ServiceNowSNMPTrapSender/blob/master/trap_sender.png?raw=true)]()

## ServiceNow Alert Business Rule

(function executeRule(current, previous /*null when async*/) {
	
	/*
		Get the resource from the alert description using the regex
		Find the CI based on the name and set Configuration Item for the sys ID that was identified
	*/
	
	
	
	var descr = current.description;
	
	// Update CI based on name
	var value = _getFeildValue(descr, "resource");
	
	if(value){
		// set resource field
		current.resource = value;
		
		// set cmdb field
		var grCmdbCi = new GlideRecord('cmdb_ci');
		grCmdbCi.addEncodedQuery("name=" + value);
		grCmdbCi.setLimit(1);
		grCmdbCi.query();
		while (grCmdbCi.next()) {
			var sysId = grCmdbCi.getValue('sys_id');
			gs.info("VF: sys_id:" + sysId);
			current.cmdb_ci = sysId;
		}
	}
	
	// Update key
	value = _getFeildValue(descr, "message_key");
	if(value){
		current.message_key = value;
	}
	
	
	// Get field value from concatinated string
	function _getFeildValue(descr, field){
		var reg = field + ":([^,]+)";
		var regx = new RegExp(reg, "i");
		var resource = descr.match(regx)[0]; // first result
		var value = resource.split(':')[1];  // 2nd spit 
		return value;
	}
	
    })(current, previous);






## ServiceNow Alert

[![N|SNow Alert](https://github.com/RahmanM/ServiceNowSNMPTrapSender/blob/master/servicenow_alert.png?raw=true)]()
