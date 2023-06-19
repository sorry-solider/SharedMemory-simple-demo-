import mmap
import os
import time
import contextlib

def send_data_to_unity(data):
    # 创建共享内存
    with contextlib.closing(mmap.mmap(-1, 1024, tagname='SharedMemory', access=mmap.ACCESS_WRITE)) as m:
        m.seek(0)
        m.write((str(data)).encode())
        m.flush()

if __name__ == "__main__":
    for i in range(10):
        send_data_to_unity(i)
        time.sleep(1)
