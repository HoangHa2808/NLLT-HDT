using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHinhHoc1
{
	class Program
	{
		enum MainMenu
		{
			Thoat,
			Nhap,
			Xuat,
			HinhVuong,
			HinhTron,
			HinhChuNhat,
			Chung,
			TongHop, Ghi
		}

		enum MenuVuong
		{
			XuatVeMenu,
			TimHinhVuongCoSVBangX = 1,
			TimMaxMinDTCVHVuong, SapXepHVuong,
			CanhHVMaxMin, TongDTCVHVuong, DemSLHVuong
		}

		enum MenuTron
		{
			XuatVeMenu,
			TimHinhTronCoSVBangX = 1,
			TimMaxMinDTCVHTron, SapXepHTron,
			CanhHTMaxMin, TongDTCVHTron, DemSLHTron
		}

		enum MenuChuNhat
		{
			XuatVeMenu,
			TimHinhCNCoSVBangX = 1,
			TimMaxMinDTCVHCN, SapXepHCN,
			CanhHCNMaxMin, TongDTCVHCN, DemSLHCN
		}

		enum Chung
		{
			XuatVeMenu,
			HinhCoDTMaxMin, HinhCoCVMaxMin,
			DemSoLuong, SapXepCacHinh, TinhTongDT,
			TinhTongCV, TinhTong, XoaHinhCoDTMaxMin,
			XoaHinhCoCVMaxMin, XoaTaiViTri, ThemHinhTaiViTri,
			TinhTongCacHinh, TimKieuHinhCoDTMaxMin, TimKieuHinhCoCVMaxMin
		}

		enum TongHop
		{
			XuatVeMenu
		}

		enum Ghi
		{
			XuatVeMenu,
			GhiHV,
			GhiHT,
			GhiHCN,
			GhiTong
		}
		static void Main(string[] args)
		{
			DanhSachHinhHoc dshh = new DanhSachHinhHoc();
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			Console.OutputEncoding = Encoding.Unicode;
			Console.WriteLine(dshh);

			while (true)
			{
				Console.Clear();
				Console.WriteLine(" =============== HỆ THỐNG MENU ===============");
				Console.WriteLine("Nhập 0 để thoát khỏi chương trình.");
				Console.WriteLine("Nhập 1 để nhập dữ liệu từ file.");
				Console.WriteLine("Nhập 2 để xuất danh sách.");
				Console.WriteLine("\t=====> Quản Lý Hình Học <=====");
				Console.WriteLine("Nhập 3 để xem chức năng của hình vuông.");
				Console.WriteLine("Nhập 4 để xem chức năng của hình tròn.");
				Console.WriteLine("Nhập 5 để xem chức năng của hình chữ nhật.");
				Console.WriteLine("Nhập 6 để xem chức năng chung của các hình học.");
				Console.WriteLine("Nhập 7 để tổng hợp danh sách các hình học");
				Console.WriteLine("Nhập 8 để ghi vào danh sách");
				Console.WriteLine("===============================================");
				Console.WriteLine();
				Console.Write("Nhập số thứ tự: ");
				MainMenu menu = (MainMenu)int.Parse(Console.ReadLine());
				bool canContinue = true;
				switch (menu)
				{
					case MainMenu.Thoat:
						Console.Clear();
						Console.WriteLine("Cảm ơn vì đã sử dụng.");
						Console.WriteLine("\nHẹn gặp lại.");
						return;
						//break;

					case MainMenu.Nhap:
						Console.Clear();
						dshh.NhapTuFile();
						break;

					case MainMenu.Xuat:
						Console.Clear();
						Console.WriteLine(" => Danh sách hình học." + dshh.ToString());
						Console.WriteLine("\nNhập một phím bất kỳ để tiếp tục.");
						Console.ReadKey();
						break;

					#region Hình Vuông
					case MainMenu.HinhVuong:
						{
							while (canContinue)
							{
								Console.Clear();
								Console.WriteLine("\t\t<=== Hình Vuông ===>");
								Console.WriteLine("Nhập 0. Trở về Menu chinh.");
								Console.WriteLine("Nhập {0}. Tìm tất cả các hình có S, V là x.", (int)MenuVuong.TimHinhVuongCoSVBangX);
								Console.WriteLine("Nhập {0}. Tìm hình có diện tích, chu vi nhỏ nhất.", (int)MenuVuong.TimMaxMinDTCVHVuong);
								Console.WriteLine("Nhập {0}. Sắp xếp tăng dần, giảm dần diện tích.", (int)MenuVuong.SapXepHVuong);
								Console.WriteLine("Nhập {0}. Tìm cạnh nhỏ nhất, lớn nhất.", (int)MenuVuong.CanhHVMaxMin);
								Console.WriteLine("Nhập {0}. Tính tổng diện tích, chu vi.", (int)MenuVuong.TongDTCVHVuong);
								Console.WriteLine("Nhập {0}. Đếm số lượng hình.", (int)MenuVuong.DemSLHVuong);
								Console.WriteLine("====================================================");
								Console.Write("Nhập số thứ tự: ");
								MenuVuong nhap = (MenuVuong)int.Parse(Console.ReadLine());
								switch (nhap)
								{
									case 0:
										canContinue = false;
										break;

									case MenuVuong.TimHinhVuongCoSVBangX:
										Console.Clear();
										Console.Write("Nhập diện tích hình vuông: x = ");
										float n = float.Parse(Console.ReadLine());
										Console.Write("Nhập chu vi hình vuông: x = ");
										float b = float.Parse(Console.ReadLine());

										List<HinhHoc> dtVuong = dshh.TimDTTheoX<HinhVuong>(n);
										foreach (var item in dtVuong)
										{
											Console.WriteLine(item);
										}

										List<HinhHoc> cvVuong = dshh.TimCVTheoX<HinhVuong>(b);
										foreach (var item in cvVuong)
										{
											Console.WriteLine(item);
										}

										break;

									case MenuVuong.TimMaxMinDTCVHVuong:
										Console.Clear();
										Console.Write("Diện tích nhỏ nhất là: ");
										dshh.TinhHVuongCoDTMin().Xuat();
										Console.WriteLine();

										Console.Write("Chu vi nhỏ nhất là: ");
										dshh.TinhHVuongCoCVMin().Xuat();
										break;

									case MenuVuong.SapXepHVuong:
										Console.Clear();
										Console.WriteLine("\tSap xep tang, giam theo dien tich, chu vi: ");
										Console.WriteLine("=> Tang dan");
										dshh.sortByT<HinhVuong>(false).Xuat();
										Console.WriteLine();

										Console.WriteLine("=> Giam dan");
										dshh.sortByG<HinhVuong>(false).Xuat();
										break;

									case MenuVuong.CanhHVMaxMin:
										Console.Clear();
										Console.WriteLine("Canh lon nhat la: ");
										dshh.TimCanhHVuongMax().Xuat();
										Console.WriteLine();

										Console.WriteLine("Canh nho nhat la: ");
										dshh.TimCanhHVuongMin().Xuat();
										break;

									case MenuVuong.TongDTCVHVuong:
										Console.Clear();
										break;

									case MenuVuong.DemSLHVuong:
										Console.Clear();
										Console.Write("So luong hinh hoc la: ");
										Console.WriteLine(dshh.DemSLHinh<HinhVuong>().ToString());
										break;
								}
								Console.WriteLine("\nNhập một phím bất kỳ để tiếp tục.");
								Console.ReadKey();
								Console.Clear();
							}
						}
						break;
					#endregion

					#region Hình Tròn
					case MainMenu.HinhTron:
						{
							while (canContinue)
							{
								Console.Clear();
								Console.WriteLine("\t\t<=== Hình Tròn ===>");
								Console.WriteLine("Nhập 0. Trở về Menu chinh.");
								Console.WriteLine("Nhập {0}. Tìm tất cả các hình có S, V là x.", (int)MenuTron.TimHinhTronCoSVBangX);
								Console.WriteLine("Nhập {0}. Tìm hình có diện tích, chu vi nhỏ nhất.", (int)MenuTron.TimMaxMinDTCVHTron);
								Console.WriteLine("Nhập {0}. Sắp xếp tăng dần, giảm dần diện tích.", (int)MenuTron.SapXepHTron);
								Console.WriteLine("Nhập {0}. Tìm cạnh nhỏ nhất, lớn nhất.", (int)MenuTron.CanhHTMaxMin);
								Console.WriteLine("Nhập {0}. Tính tổng diện tích, chu vi.", (int)MenuTron.TongDTCVHTron);
								Console.WriteLine("Nhập {0}. Đếm số lượng hình.", (int)MenuTron.DemSLHTron);
								Console.WriteLine("====================================================");
								Console.Write("Nhập số thứ tự: ");
								MenuTron nhap = (MenuTron)int.Parse(Console.ReadLine());
								switch (nhap)
								{
									case 0:
										canContinue = false;
										break;

									case MenuTron.TimHinhTronCoSVBangX:
										Console.Clear();
										Console.Write("Nhập diện tích hình tròn:x = ");
										float t = float.Parse(Console.ReadLine());
										Console.Write("Nhập chu vi hình tròn:x = ");
										float d = float.Parse(Console.ReadLine());

										List<HinhHoc> dtTron = dshh.TimCVTheoX<HinhVuong>(t);
										foreach (var item in dtTron)
										{
											Console.WriteLine(item);
										}

										List<HinhHoc> cvTron = dshh.TimCVTheoX<HinhVuong>(d);
										foreach (var item in cvTron)
										{
											Console.WriteLine(item);
										}
										break;

									case MenuTron.TimMaxMinDTCVHTron:
										Console.Clear();
										Console.Write("Dien tich nho nhat la: ");
										dshh.TinhHTronCoDTMin().Xuat();
										Console.WriteLine();

										Console.Write("Chu vi nho nhat la: ");
										dshh.TinhHTronCoCVMin().Xuat();
										break;

									case MenuTron.SapXepHTron:
										Console.Clear();
										Console.WriteLine("\tSap xep tang, giam theo dien tich, chu vi: ");
										Console.WriteLine("=> Tang dan");
										dshh.sortByT<HinhTron>(false).Xuat();
										Console.WriteLine();

										Console.WriteLine("=> Giam dan");
										dshh.sortByG<HinhTron>(false).Xuat();
										break;

									case MenuTron.CanhHTMaxMin:
										Console.Clear();
										Console.WriteLine("Canh lon nhat la: ");
										dshh.TimCanhHTronMax().Xuat();
										Console.WriteLine();

										Console.WriteLine("Canh nho nhat la: ");
										dshh.TimCanhHTronMin().Xuat();
										break;

									case MenuTron.TongDTCVHTron:
										Console.Clear();
										break;

									case MenuTron.DemSLHTron:
										Console.Clear();
										Console.Write("So luong hinh hoc la: ");
										Console.WriteLine(dshh.DemSLHinh<HinhTron>().ToString());
										break;

								}
								Console.WriteLine("\nNhập một phím bất kỳ để tiếp tục.");
								Console.ReadKey();
								Console.Clear();
							}
						}
						break;
#endregion 

					#region Hình Chữ Nhật
					case MainMenu.HinhChuNhat:
						{
							Console.Clear();
							while (canContinue)
							{
								Console.Clear();
								Console.WriteLine("\t\t<=== Hình Chữ Nhật ===>");
								Console.WriteLine("Nhập {0}. Trở về Menu chinh.", (int)MenuChuNhat.XuatVeMenu);
								Console.WriteLine("Nhập 1. Tìm tất cả các hình có S, V là x.", (int)MenuChuNhat.TimHinhCNCoSVBangX);
								Console.WriteLine("Nhập 2. Tìm hình có diện tích, chu vi nhỏ nhất.", (int)MenuChuNhat.TimMaxMinDTCVHCN);
								Console.WriteLine("Nhập 3. Sắp xếp tăng dần, giảm dần diện tích.", (int)MenuChuNhat.SapXepHCN);
								Console.WriteLine("Nhập 4. Tìm cạnh nhỏ nhất, lớn nhất.", (int)MenuChuNhat.CanhHCNMaxMin);
								Console.WriteLine("Nhập 5. Tính tổng diện tích, chu vi.", (int)MenuChuNhat.TongDTCVHCN);
								Console.WriteLine("Nhập 6. Đếm số lượng hình.", (int)MenuChuNhat.DemSLHCN);
								Console.WriteLine("====================================================");
								Console.Write("Nhập số thứ tự: ");
								MenuChuNhat nhap = (MenuChuNhat)int.Parse(Console.ReadLine());
								switch (nhap)
								{
									case MenuChuNhat.XuatVeMenu:
										canContinue = false;
										break;

									case MenuChuNhat.TimHinhCNCoSVBangX:
										Console.Clear();
										Console.Write("Nhập diện tích hình chữ nhật: x = ");
										float t = float.Parse(Console.ReadLine());
										Console.Write("Nhập chu vi hình chữ nhật: x = ");
										float d = float.Parse(Console.ReadLine());

										List<HinhHoc> dtCN = dshh.TimCVTheoX<HinhChuNhat>(t);
										foreach (var item in dtCN)
										{
											Console.WriteLine(item);
										}

										List<HinhHoc> cvCN = dshh.TimCVTheoX<HinhChuNhat>(d);
										foreach (var item in cvCN)
										{
											Console.WriteLine(item);
										}
										break;

									case MenuChuNhat.TimMaxMinDTCVHCN:
										Console.Clear();
										Console.Write("Dien tich nho nhat la: ");
										dshh.TinhHCNCoDTMin().Xuat();
										Console.WriteLine();

										Console.Write("Chu vi nho nhat la: ");
										dshh.TinhHCNCoCVMin().Xuat();
										break;

									case MenuChuNhat.SapXepHCN:
										Console.Clear();
										Console.WriteLine("\tSap xep tang, giam theo dien tich, chu vi: ");
										Console.WriteLine("=> Tang dan");
										dshh.sortByT<HinhChuNhat>(false).Xuat();
										Console.WriteLine();

										Console.WriteLine("=> Giam dan");
										dshh.sortByG<HinhChuNhat>(false).Xuat();
										break;

									case MenuChuNhat.CanhHCNMaxMin:
										Console.Clear();
										Console.WriteLine("Canh lon nhat la: ");
										dshh.TimCanhHCNMax().Xuat();
										Console.WriteLine();

										Console.WriteLine("Canh nho nhat la: ");
										dshh.TimCanhHCNMin().Xuat();
										break;

									case MenuChuNhat.TongDTCVHCN:
										Console.Clear();
										break;

									case MenuChuNhat.DemSLHCN:
										Console.Clear();
										Console.Write("So luong hinh hoc la: ");
										Console.WriteLine(dshh.DemSLHinh<HinhChuNhat>().ToString());
										break;
								}
								Console.WriteLine("\nNhập một phím bất kỳ để tiếp tục.");
								Console.ReadKey();
								Console.Clear();
							}

						}
						break;
					#endregion

					#region Chung
					case MainMenu.Chung:
						{
							while (canContinue)
							{
								Console.Clear();
								Console.WriteLine("================= Chức năng chung ==================");
								Console.WriteLine("Nhập 0. Trở về Menu chinh.");
								Console.WriteLine("Nhập {0}. Tìm tất cả hình có diện tích lớn nhất, nhỏ nhất.", (int)Chung.HinhCoDTMaxMin);
								Console.WriteLine("Nhập {0}. Tìm tất cả hình có chu vi lớn nhất, nhỏ nhất.", (int)Chung.HinhCoCVMaxMin);
								Console.WriteLine("Nhập {0}. Đếm số lượng hình học.", (int)Chung.DemSoLuong);
								Console.WriteLine("Nhập {0}. Sắp xếp các hình.", (int)Chung.SapXepCacHinh);
								Console.WriteLine("Nhập {0}. Tổng diện tích các hình học.", (int)Chung.TinhTongDT);
								Console.WriteLine("Nhập {0}. Tổng chu vi các hình học.", (int)Chung.TinhTongCV);
								Console.WriteLine("Nhập {0}. Tổng các hình học.", (int)Chung.TinhTong);
								Console.WriteLine("Nhập {0}. Xóa hình có diện tích lớn nhất, nhỏ nhất.", (int)Chung.XoaHinhCoDTMaxMin);
								Console.WriteLine("Nhập {0}. Xóa hình có chu vi lớn nhất, nhỏ nhất.", (int)Chung.XoaHinhCoCVMaxMin);
								Console.WriteLine("Nhập {0}. Xóa tại vị trí.", (int)Chung.XoaTaiViTri);
								Console.WriteLine("Nhập {0}. Thêm hình bất kỳ vào vị trí x.", (int)Chung.ThemHinhTaiViTri);
								Console.WriteLine("Nhập {0}. Tính tổng.", (int)Chung.TinhTongCacHinh);
								Console.WriteLine("Nhập {0}. Tìm kiểu hình có tổng diện tích lớn nhất, nhỏ nhất.", (int)Chung.TimKieuHinhCoDTMaxMin);
								Console.WriteLine("Nhập {0}. Tìm kiểu hình có tổng chu vi lớn nhất, nhỏ nhất.", (int)Chung.TimKieuHinhCoCVMaxMin);
								Console.WriteLine("=======================================================");
								Console.WriteLine();
								Console.Write("Nhập số thứ tự: ");
								Chung nhapthem = (Chung)int.Parse(Console.ReadLine());

								switch (nhapthem)
								{
									case 0:
										canContinue = false;
										break;

									case Chung.HinhCoDTMaxMin:
										Console.Clear();
										Console.WriteLine("Hinh co dien tich lon nhat la: ");
										Console.WriteLine(dshh.TinhHinhCoDTMax());
										Console.WriteLine();

										Console.WriteLine("Hinh co dien tich nho nhat la: ");
										Console.WriteLine(dshh.TinhHinhCoDTMin());
										break;

									case Chung.HinhCoCVMaxMin:
										Console.Clear();
										Console.WriteLine("Hinh co chu vi lon nhat la: ");
										Console.WriteLine(dshh.TinhHinhCoCVMax());
										Console.WriteLine();

										Console.WriteLine("Hinh co chu vi nho nhat la: ");
										Console.WriteLine(dshh.TinhHinhCoCVMin());
										break;

									case Chung.DemSoLuong:
										Console.Clear();
										Console.WriteLine("So luong cac hinh la:");
										Dictionary<string, int> result = dshh.DemSLHinhHoc();
										foreach (var item in result)
										{
											Console.Write('\t');
											Console.WriteLine(item.Key + ":" + item.Value);
										}
										break;

									case Chung.SapXepCacHinh:
										Console.Clear();
										Console.WriteLine("\tSap xep tang, giam theo dien tich, chu vi: ");
										Console.WriteLine("=> Tang dan");
										dshh.sortByT<HinhHoc>(true).Xuat();
										Console.WriteLine();

										Console.WriteLine("=> Giam dan");
										dshh.sortByG<HinhHoc>(true).Xuat();
										break;


									case Chung.TinhTongDT:
										Console.Clear();
										Console.Write("Tong dien tich cac hinh la: ");
										Console.WriteLine(dshh.TongDTCacHinh());
										//dshh.Xuat();
										break;

									case Chung.TinhTongCV:
										Console.Clear();
										Console.Write("Tong chu vi cac hinh la: ");
										Console.WriteLine(dshh.TongCVCacHinh());
										//dshh.Xuat();
										break;

									case Chung.TinhTong:
										Console.Clear();
										Console.Write("Tong cac hinh la: ");
										Console.WriteLine(dshh.TongCacHinh());
										break;

									case Chung.XoaHinhCoDTMaxMin:
										Console.Clear();
										Console.WriteLine("\t<= Xoa hinh co dien tich lon nhat =>");
										Console.WriteLine("Hinh co diện tích lớn nhất la:" + dshh.TinhHinhCoDTMax());
										Console.WriteLine("=> Danh sach sau khi xoa");
										List<HinhHoc> dtMax = dshh.XoaHinhCoDTMax();
										foreach (HinhHoc re in dtMax)
										{
											Console.WriteLine(re.ToString());
										}
										Console.WriteLine();

										Console.WriteLine("\t<= Xoa hinh co dien tich nho nhat =>");
										Console.WriteLine("Hinh co diện tích nhỏ nhất la:" + dshh.TinhHinhCoDTMin());
										Console.WriteLine("=> Danh sach sau khi xoa");
										List<HinhHoc> dtMin = dshh.XoaHinhCoDTMin();
										foreach (HinhHoc re in dtMin)
										{
											Console.WriteLine(re.ToString());
										}
										break;

									case Chung.XoaHinhCoCVMaxMin:
										Console.Clear();
										Console.WriteLine("\t<= Xoa hinh co chu vi lon nhat =>");
										Console.WriteLine("Hinh co chu vi lon nhat la:" + dshh.TinhHinhCoCVMax());
										Console.WriteLine("=> Danh sach sau khi xoa");
										List<HinhHoc> cvMax = dshh.XoaHinhCoCVMax();
										foreach (HinhHoc re in cvMax)
										{
											Console.WriteLine(re.ToString());
										}

										Console.WriteLine("\t<= Xoa hinh co chu vi nho nhat =>");
										Console.WriteLine("Hinh co chu vi nho nhat la:" + dshh.TinhHinhCoCVMin());
										Console.WriteLine("=> Danh sach sau khi xoa");
										List<HinhHoc> cvMin = dshh.XoaHinhCoCVMin();
										foreach (HinhHoc re in cvMin)
										{
											Console.WriteLine(re.ToString());
										}
										break;

									case Chung.XoaTaiViTri:
										Console.Clear();
										Console.Write("Nhập vị trí cần xóa (tu 1 -> " + dshh.TongCacHinh() + " ): x = ");
										int x = int.Parse(Console.ReadLine());
										dshh.XoaTaiViTri(x);
										dshh.Xuat();
										break;

									case Chung.ThemHinhTaiViTri:
										Console.Clear();
										Console.WriteLine("Nhap 0 de them hinh tron");
										Console.WriteLine("Nhap 1 de them hinh vuong");
										Console.WriteLine("Nhap 2 de them hinh chu nhat");
										int what = int.Parse(Console.ReadLine());
										HinhHoc a;

										switch (what)
										{
											case 0:
												{
													Console.WriteLine("Nhap vao ban kinh hinh tron");
													float r = float.Parse(Console.ReadLine());
													a = new HinhTron(r);
													break;
												}

											case 1:
												{
													Console.WriteLine("Nhap vao canh hinh vuong");
													float c = float.Parse(Console.ReadLine());
													a = new HinhVuong(c);
													break;
												}

											case 2:
												{
													Console.WriteLine("Nhap vao chieu dai hinh chu nhat");
													float cD = float.Parse(Console.ReadLine());

													Console.WriteLine("Nhap vao chieu rong hinh chu nhat");
													float cR = float.Parse(Console.ReadLine());
													a = new HinhChuNhat(cD, cR);
													break;
												}
											default:
												{
													a = new HinhHoc();
												}
												break;
										}
										Console.Write("Nhap vi tri can them(1 -> " + dshh.TongCacHinh() + "): ");
										int vt = int.Parse(Console.ReadLine());
										Console.WriteLine("Danh sach sau khi thay doi la: ");
										dshh.ThemHinhTaiViTri(a, vt); dshh.Xuat();
										break;

									case Chung.TinhTongCacHinh:
										Console.Clear();
										Console.WriteLine("Tong dien tich hinh vuong: " + dshh.TinhTongDT<HinhVuong>().ToString());

										Console.WriteLine("Tong dien tich hinh tron: " + dshh.TinhTongDT<HinhTron>().ToString());

										Console.WriteLine("Tong dien tich hinh chu nhat: " + dshh.TinhTongDT<HinhChuNhat>().ToString());
										break;

									case Chung.TimKieuHinhCoDTMaxMin:
										Console.Clear();
										Console.WriteLine("Kiểu hình có diện tích lớn nhất là: " + dshh.TimKieuHCoDTMax());
										Console.WriteLine("\nKiểu hình có diện tích nhỏ nhất là: " + dshh.TimKieuHCoDTMin());
										break;

									case Chung.TimKieuHinhCoCVMaxMin:
										Console.Clear();
										Console.WriteLine("Kiểu hình có chu vi lớn nhất là: " + dshh.TimKieuHCoCVMax());
										Console.WriteLine("\nKiểu hình có chu vi nhỏ nhất là: " + dshh.TimKieuHCoCVMin());
										break;
								}
								Console.WriteLine();
								Console.WriteLine("Nhập một phím bất kỳ để tiếp tục.");
								Console.ReadKey();
								Console.Clear();
							}
						}
						break;
					#endregion

					#region Tổng Hợp
					case MainMenu.TongHop:
						Console.WriteLine("{0}. Tổng hợp.", (int)MainMenu.TongHop);

						Console.WriteLine("\tBANG TONG HOP THONG TIN");
						Console.WriteLine("1) Tổng số các đối tượng hình học: " + dshh.TongCacHinh());
						Console.WriteLine("2) Tong so hinh vuong: " + dshh.DemSLHinh<HinhVuong>());
						Console.WriteLine("3) Tong so hinh tron: " + dshh.DemSLHinh<HinhTron>());
						Console.WriteLine("4) Tong so hinh chu nhat: " + dshh.DemSLHinh<HinhChuNhat>());
						Console.WriteLine();
						Console.WriteLine("A. Danh sach hinh vuong:");
						kq = dshh.sortByT<HinhVuong>(false);
						Console.Write(kq);
						Console.WriteLine();
						Console.WriteLine();
						Console.WriteLine("B. Danh sach hinh tron:");
						kq = dshh.sortByT<HinhTron>(false);
						Console.Write(kq);
						Console.WriteLine();
						Console.WriteLine();
						Console.WriteLine("C. Danh sach hinh chu nhat:");
						kq = dshh.sortByT<HinhChuNhat>(false);
						Console.Write(kq);
						Console.WriteLine();
						Console.WriteLine("\nNhập một phím bất kỳ để tiếp tục.");
						Console.ReadKey();
						break;
					#endregion

					#region Ghi File
					case MainMenu.Ghi:
						while (canContinue)
						{
							Console.Clear();
							Console.WriteLine("=========== Ghi ==========");
							Console.WriteLine("0. Quay tro lai menu chinh.");
							Console.WriteLine("{0}. Ghi danh sach hinh vuong xuong file.", (int)Ghi.GhiHV);
							Console.WriteLine("{0}. Ghi danh sach hinh tron vuong file.", (int)Ghi.GhiHT);
							Console.WriteLine("{0}. Ghi danh sach hinh chu nhat xuong file.", (int)Ghi.GhiHCN);
							Console.WriteLine("{0}. Ghi bang tong hop thong tin xuong file.", (int)Ghi.GhiTong);
							Console.WriteLine("============================");
							Console.Write("Nhập thứ tự: ");
							Ghi ds = (Ghi)int.Parse(Console.ReadLine());

							switch (ds)
							{
								case 0:
									canContinue = false;
									break;

								case Ghi.GhiHV:
									Console.Clear();
									Console.WriteLine("{0}. Ghi danh sach hinh vuong xuong file.", (int)Ghi.GhiHV);
									dshh.GhiDanhSachHinhVuongXuongFile();
									Console.WriteLine("Danh sach hinh vuong da duoc ghi xuong file hvuong.txt");

									break;
								case Ghi.GhiHT:
									Console.Clear();
									Console.WriteLine("{0}. Ghi danh sach hinh tron xuong file.", (int)Ghi.GhiHT);

									dshh.GhiDanhSachHinhTronXuongFile();
									Console.WriteLine("Danh sach hinh tron da duoc ghi xuong file htron.txt");

									break;
								case Ghi.GhiHCN:
									Console.Clear();
									Console.WriteLine("{0}. Ghi danh sach hinh chu nhat xuong file.", (int)Ghi.GhiHCN);
									dshh.GhiDanhSachHinhChuNhatXuongFile();
									Console.WriteLine("Danh sach hinh chu nhat da duoc ghi xuong file hchunhat.txt");
									break;

								case Ghi.GhiTong:
									Console.Clear();
									Console.WriteLine("{0}. Ghi bang tong hop thong tin xuong file.", (int)Ghi.GhiTong);
									dshh.GhiBangTongHopXuongFile();
									Console.WriteLine("Bang tong hop thong tin da duoc ghi xuong file tonghop.txt");
									break;
							}
							Console.WriteLine("\nNhập một phím bất kỳ để tiếp tục.");
							Console.ReadKey();
							Console.Clear();
						}
						break;
						#endregion

				}
				//Console.WriteLine("Nhập một phím bất kỳ để tiếp tục.");
				//Console.ReadKey();
				Console.Clear();
			}
		}
	}
}
