# base64-cli

Compress/Decompress strings to base64 or Encode/Decode strings to base64

## Usage

```
  -i, --input         Required. Input string

  -c, --compress      Compress string to base64

  -d, --decompress    Decompress base64 string

  -E, --encode        Encode string to base64

  -D, --decode        Decode string from base64

  --help              Display this help screen.

  --version           Display version information.
```

## Usage Examples

```
base64-cli -i "hello world" -c
base64-cli -i BYUwNmD2AEDukCcwBMg= -d
base64-cli -i "hello world" -E
base64-cli -i aGVsbG8gd29ybGQ= -D
```

## License

[WTFPL](LICENSE)
