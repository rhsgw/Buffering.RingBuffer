# Buffering.RingBuffer

## 概要

作成時に容量を決めて使用するFIFO。一度データを読み取った後も、新規データで上書きされるまでは読み取り開始位置を戻すことができる

## 使用方法

```
var buffer = new RingBuffer<int>(5);
Console.WriteLine(buffer.LengthToRead); // 0

// 書き込み
Console.WriteLine(buffer.Margin); // 5
await buffer.WriteAsync(-1,CancellationToken.None);
await buffer.WriteAsync(0,CancellationToken.None);
await buffer.WriteAsync(1,CancellationToken.None);
await buffer.WriteAsync(2,CancellationToken.None);
Console.WriteLine(buffer.Margin); // 1

// 読み取り
Console.WriteLine(buffer.LengthToRead); // 4
var result = await buffer.ReadAsync(CancellationToken.None); // -1
result = await buffer.ReadAsync(CancellationToken.None); // 0
result = await buffer.ReadAsync(CancellationToken.None); // 1
Console.WriteLine(buffer.LengthToRead); // 1

// 読み取り位置を戻す (条件指定)
var offset = await buffer.SeekBackAsync(i => i < 1,CancellationToken.None); // specify condition / offset:2
result = await buffer.ReadAsync(CancellationToken.None); // 0
```

