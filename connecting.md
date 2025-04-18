# Connecting IPhone to Debian

- Usually it has been working out of the box
- Currently it is not working
- We can build and update libraries used by ifuse

## Install dependencies

- Most are installed already, but this should cover if something missing

```bash
sudo apt-get install build-essential pkg-config checkinstall autoconf automake libtool-bin libplist-dev libfuse3-dev libssl-dev
```

### UsbMuxD

- USBMUXD is a daemon that handles communication between iOS devices and the host computer.

```bash
git clone https://github.com/libimobiledevice/usbmuxd.git
cd usbmuxd
./autogen.sh
make
sudo make install
```

After installing usbmuxd, restart the service:

```bash
sudo systemctl restart usbmuxd
```

### LibIMobileDevice

- libimobiledevice is a software library that talks the protocols to support iOS devices.
- It is used by ifuse to mount iOS devices.
- It is also used by other software to communicate with iOS devices.

```bash
git clone https://github.com/libimobiledevice/libimobiledevice.git
cd libimobiledevice
./autogen.sh
make
sudo make install
```

After installing libimobiledevice, update the library cache:

```bash
sudo ldconfig
```

You can verify the installation by checking if the libraries are detected:

```bash
pkg-config --modversion libimobiledevice-1.0
ideviceinfo --version
```

### IFuse

- ifuse is a FUSE filesystem for mounting iOS devices.

Build

```bash
git clone https://github.com/libimobiledevice/ifuse.git
cd ifuse
./autogen.sh
make
sudo make install
```

Add user to fuse group

```bash
sudo modprobe fuse
sudo adduser antti fuse
```
