app.controller("TextInverterController", function ($scope, TextInverterService) {
    $scope.PostData = function () {
        var data = $scope.input;
        var promisePost = TextInverterService.post(data);
        promisePost.then(function (response) {
            console.log("response success " + response.data);
            $scope.result = response.data
        }, function (error) {
            console.log("Response failed " + error.log);
        });
    }
})