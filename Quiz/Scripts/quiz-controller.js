var quizApp = angular.module('QuizApp', ['timer']);

quizApp.controller('QuizCtrl', function ($scope, $http) {
        $scope.options = [];
        $scope.page = 0;
        $scope.progress = 0;
        $scope.started = false;
        $scope.buttonText = "Next";
        $scope.countDown = 60;


        $scope.start = function () {

            $scope.started = true;
            $scope.nextQuestion();
            $scope.countDown = 60;
            $scope.finished = false;
            $scope.$broadcast('timer-start');
            $scope.buttonText = "Next";
        };


        $scope.finish = function () {
            console.log('finished');

            $scope.started = false;
            $scope.finished = true;
           $scope.$broadcast('timer-stop');
            $scope.progress = 100;
        };

        $scope.expired = function () {

            console.log('expired');

            $scope.$apply(function () {
                $scope.started = false;
                $scope.finished = true;
            });

        };


        $scope.nextQuestion = function () {
            $scope.options = [];
            $scope.answers = [];


            $progress = $scope.page  * 100


            $http.get("/api/quiz/Get").success(function (data, status, headers, config) {
                $scope.questions = data.questions;
                $scope.progress = ((data.currentPage - 1 )/ data.totalPage) * 100;
                $scope.countDown = data.countDown;
                $scope.scores = data.score;

                if (data.finished) {
                    $scope.finish();
                }
                    
                if (data.currentPage == data.totalPage) {
                    $scope.buttonText = "Complete";
                }

            }).error(function (data, status, headers, config) {
                $scope.title = "Oops... something went wrong";
                $scope.working = false;
            });

           
        };


        $scope.submitForm = function ()
        {

            var answers = [];

            angular.forEach($scope.answers, function (value, key) {
                this.push({ 'questionId': $scope.questions[key].id, 'optionId': value });
            }, answers);
           
            console.log(answers);

            $http.post('/api/quiz/Post', answers).success(function (data, status, headers, config) {
                $scope.correctAnswer = (data === "true");
                $scope.working = false;

                $scope.nextQuestion();

            }).error(function (data, status, headers, config) {
                $scope.title = "Oops... something went wrong";
                $scope.working = false;
            });

        };

});
