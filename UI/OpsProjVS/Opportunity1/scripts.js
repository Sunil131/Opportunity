function moveDown(type){
		 switch(type){	
		 case 'prepaid':$('#prepaid').hide();
						$('#postpaid').hide();
						$('#tv').hide();
						$('#datacard').hide();
						$('#utility').hide();
		 				$('#prepaid').show();
		 				document.getElementById('aboutLink').click();
						 break;
		case 'postpaid':$('#prepaid').hide();
						$('#postpaid').hide();
						$('#tv').hide();
						$('#datacard').hide();
						$('#utility').hide();		 
		 				$('#postpaid').show();
		 				document.getElementById('aboutLink').click();
						 break;
						 
		 case 'tv':		$('#prepaid').hide();
						$('#postpaid').hide();
						$('#tv').hide();
						$('#datacard').hide();
						$('#utility').hide();		 		 	
		 				$('#tv').show();
		 				document.getElementById('aboutLink').click();
						 break;
		case 'datacard':$('#prepaid').hide();
						$('#postpaid').hide();
						$('#tv').hide();
						$('#datacard').hide();
						$('#utility').hide();				
						$('#datacard').show();
						document.getElementById('aboutLink').click();
						 break;
		case 'utility':	$('#prepaid').hide();
						$('#postpaid').hide();
						$('#tv').hide();
						$('#datacard').hide();
						$('#utility').hide();		
						$('#utility').show();
						document.getElementById('aboutLink').click();
						 break;		
		case 'pay':document.getElementById('pay').click();
						 break;		
						 
				 
	 }
	 
	 
	
		
	
}



