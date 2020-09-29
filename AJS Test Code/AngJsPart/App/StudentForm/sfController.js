studentFormsApp.controller('sfController',  
    function sfController($scope, sfService) {  
        $scope.student = sfService.student;  
    });  
