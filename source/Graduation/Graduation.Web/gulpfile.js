const gulp = require('gulp');
const uglify = require('gulp-uglify');
const cssnano = require('gulp-cssnano');
const autoprefixer = require('gulp-autoprefixer');
const sass = require('gulp-sass');
const sourcemaps = require('gulp-sourcemaps');
const mode = require('gulp-mode')();
const  _ = require('lodash');

const webpack = require('webpack');
const webpackStream = require('webpack-stream');
const webpackConfiguration = require('./webpack.config.js')

gulp.task('build-sass', () =>
{
    return gulp.src('Theme/scss/index.scss')
        .pipe(mode.development(sourcemaps.init()))
        .pipe(sass().on('error', sass.logError))
        .pipe(autoprefixer({
            overrideBrowserslist: ['> 1%']
        }))
        .pipe(cssnano())
        .pipe(mode.development(sourcemaps.write()))
        .pipe(gulp.dest('wwwroot/css'));
});

gulp.task('build-ts', () =>
{
    return gulp.src('Theme/ts/index.ts')
        .pipe(webpackStream(webpackConfiguration, webpack, function(err, stats) {
            /* Use stats to do more things if needed */
        }))
        .pipe(gulp.dest('wwwroot/js'));
})

gulp.task('build', gulp.series('build-ts', 'build-sass'));

gulp.task('default', () => 
{
    // throws exception on error.
    // gulp.watch(
    //     ['Theme/ts/*.ts','Theme/ts/*/*.ts'],
    //     { ignoreInitial: false },
    //     gulp.series('build-ts')
    // );

    gulp.watch(
        ['Theme/scss/*.scss','Theme/scss/*/*.scss'],
        { ignoreInitial: false },
        gulp.series('build-sass')
    );
});