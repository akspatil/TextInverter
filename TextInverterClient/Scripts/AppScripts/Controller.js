app.controller("TextInverterController", function ($scope, TextInverterService) {
    $scope.PostData = function () {
        var data = $scope.input;
        var promisePost = TextInverterService.post(data);
        promisePost.then(function (response) {
            console.log("illi " + response.data);
            $scope.result = response.data
        }, function (error) {
            console.log("Some error occured " + error.log);
        }, function (update) {
            console.log('Noclue what is happening ' + update);
        });
    }
})