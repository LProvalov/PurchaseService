/// <binding BeforeBuild='min, dev:js' Clean='clean' />
"use strict";

var gulp = require("gulp"),
    rimraf = require("rimraf"),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin"),
    uglify = require("gulp-uglify");

var paths = {
    webroot: "./wwwroot/",
    views: "./Views/",
};

paths.js = paths.webroot + "js/**/*.js";
paths.minJs = paths.webroot + "js/**/*.min.js";
paths.css = paths.webroot + "css/**/*.css";
paths.minCss = paths.webroot + "css/**/*.min.css";
paths.concatJsDest = paths.webroot + "js/site.min.js";
paths.concatJsDev = paths.webroot + "js/site.js";
paths.concatCssDest = paths.webroot + "css/site.min.css";
paths.concatCssDev = paths.webroot + "css/site.dev.css";

gulp.task("clean:js", function (cb) {
    rimraf(paths.concatJsDest, cb);
});

gulp.task("clean:jsdev", function (cb) {
    rimraf(paths.concatJsDev, cb);
});

gulp.task("clean:css", function (cb) {
    rimraf(paths.concatCssDest, cb);
});

gulp.task("clean:cssdev", function (cb) {
    rimraf(paths.concatCssDev, cb);
});

gulp.task("clean", ["clean:js", "clean:jsdev", "clean:css", "clean:cssdev"]);


gulp.task("dev:js", function () {
    return gulp.src([paths.js, paths.views + "**/*.js", "!" + paths.minJs, "!" + paths.concatJsDev], { base: "." })
        .pipe(concat(paths.concatJsDev))
        .pipe(gulp.dest("."));
});

gulp.task("min:js", function () {
    return gulp.src([paths.js, paths.views + "**/*.js", "!" + paths.minJs, "!" + paths.concatJsDev], { base: "." })
        .pipe(concat(paths.concatJsDest))
        .pipe(uglify())
        .pipe(gulp.dest("."));
});

gulp.task("dev:css", function () {
    return gulp.src([paths.css, paths.views + "**/*.css", "!" + paths.minCss, "!" + paths.concatCssDest, "!" + paths.concatCssDev])
    .pipe(concat(paths.concatCssDev))
    .pipe(gulp.dest("."));
});

gulp.task("min:css", function () {
    return gulp.src([paths.css, paths.views + "**/*.css", "!" + paths.minCss, "!" + paths.concatCssDev, "!" + paths.concatCssDest])
        .pipe(concat(paths.concatCssDest))
        .pipe(cssmin())
        .pipe(gulp.dest("."));
});

gulp.task("min", ["min:js", "dev:css", "min:css"]);
