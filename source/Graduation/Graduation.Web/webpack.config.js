const path = require('path');

module.exports = {
  entry: './Theme/ts/index.ts',
  mode: 'development',
  devtool: 'inline-source-map',
  module: {
    rules: [
      {
        test: /\.tsx?$/,
        use: 'ts-loader',
        exclude: /node_modules/,
      },
    ],
  },
  resolve: {
    extensions: ['.tsx', '.ts', '.js'],
  },
  output: {
    filename: 'system.js',
    path: path.resolve(__dirname, 'wwwroot/js'),
  },
};