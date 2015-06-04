//opsApp.factory('NetworkAndPlanService', function ($http, $q) {
//    return {
//        GetAllNetworkCircles: function () {
//            return $http.get('http://localhost:62440/api/NetworksAndPlans/GetAllNetworkCircles')
//                .then(function (response) {
//                    console.log(response);
//            });
//        }
//    }
//});


opsApp.factory('NetworkAndPlanService', function ($http, $q) {
    return {
        GetAllNetworkCircles: function(){
            return $http({
                method: 'GET',
                url: 'http://localhost:62440/api/NetworksAndPlans/GetAllNetworkCircles',
                headers: {
                    'Content-Type':'application/json'
                }
            })
                .then(function (response) {
                    if (typeof response.data == 'object') {
                    return response.data;
                }
                else{
                    return $q.reject(response.data);
                    }
            }, function (response) {
                return $q.reject(response.data);
            })
        },
        GetAllNetworks: function () {
            return $http({
                method: 'GET',
                url: 'http://localhost:62440/api/NetworksAndPlans/GetAllNetworks',
                headers: {
                    'Content-Type': 'application/json'
                }
            })
                .then(function (response) {
                    if (typeof response.data == 'object') {
                        return response.data;
                    }
                    else {
                        return $q.reject(response.data);
                    }
                }, function (response) {
                    return $q.reject(response.data);
                })
        }
    }
});
//opsApp.factory('NetworkAndPlanService', function ($http, $q) {
//    return {
//        GetAllNetworkCircles: function () {
//            return $http({
//                method: 'GET',
//                url: 'http://localhost:62440/api/NetworksAndPlans/GetAllNetworkCircles',
//                headers: {
//                    'Content-Type': 'application/json'
//                }
//            })
//                .success(function (data, status, headers, config) {
//                    console.log('Success Fetching Data');
//                    //console.log(status);
//                    console.log(data);
//                    //console.log(headers);
//                    //console.log(config);
//                })
//                .error(function (data, status, headers, config) {
//                    console.log('Error Fetching Data');
//                    //console.log(status);
//                    //console.log(headers);
//                    console.log(config);
//                })

//        }
//    }
//});
