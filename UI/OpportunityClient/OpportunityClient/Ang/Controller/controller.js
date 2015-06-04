/**
 * @author sunilm
 */
opsApp.controller('prepaidController', function ($scope, NetworkAndPlanService) {
    //$scope.NetworkCircles = NetworkAndPlanService.GetAllNetworkCircles();
    var getNetworkCircles = function () {
        NetworkAndPlanService.GetAllNetworkCircles()
        .then(function (data) {
            $scope.NetworkCircles = data;
            console.log('Network Circle Pull Success');
        }, function (error) {
            console.log('Network Circle Pull Error:' + error);
        })
    };
    var getNetworks = function () {
        NetworkAndPlanService.GetAllNetworks()
        .then(function (data) {
            $scope.allNetworks = data;
            console.log('Networks Pull Success');
        }, function (error) {
            console.log('Network Pull Error:' + error);
        })
    };
    getNetworkCircles();
    getNetworks();
})


