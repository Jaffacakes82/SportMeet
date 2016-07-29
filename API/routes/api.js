var express = require('express');
var router = express.Router();

/* GET home page. */
router.get('/', function (req, res, next) {
    res.render('index', {
        title: 'SportMeet'
    });
});

router.post('/register', function (req, res, next) {

});

router.post('/login', function (req, res, next) {

});

router.get('/forgot', function (req, res, next) {

});

router.post('/forgot', function (req, res, next) {

});

module.exports = router;