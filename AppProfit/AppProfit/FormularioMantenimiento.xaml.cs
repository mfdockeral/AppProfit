using Syncfusion.XForms.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppProfit
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FormularioMantenimiento : ContentPage
	{
		public FormularioMantenimiento()
		{
			InitializeComponent();

			

		}

		private void BValidacion_Clicked(object sender, EventArgs e)
		{
			if (Convert.ToString(SBEstadoC.SelectedItem) == "Colmado quebrado"
				|| Convert.ToString(SBEstadoC.SelectedItem) == "Colmado cerrado"
				|| Convert.ToString(SBEstadoC.SelectedItem) == "Ventana quitada")
			{

				RB1No.IsChecked = true;
				RB2No.IsChecked = true;
				RB3No.IsChecked = true;
				SBEstadoD.SelectedItem = "No aplica";
				SBAcceso.SelectedItem = "No aplica";
				SBTa.SelectedItem = "No aplica";
				RB4No.IsChecked = true;
				CantDelivery.Text = "0";
				TipoVentana.SelectedItem = "No aplica";
				CantTramos.Text = "0";
				RB5No.IsChecked = true;
				RB6No.IsChecked = true;
				RB7No.IsChecked = true;
				RB8No.IsChecked = true;
				RB9No.IsChecked = true;
				RB10No.IsChecked = true;
				RB11No.IsChecked = true;
				RB12No.IsChecked = true;
				RB13No.IsChecked = true;
				radioGroup1.IsVisible = false;
				radioGroup2.IsVisible = false;
				radioGroup3.IsVisible = false;
				SBEstadoD.IsVisible = false;
				SBAcceso.IsVisible = false;
				SBTa.IsVisible = false;
				LBTipoVentana.IsVisible = false;
				radioGroup4.IsVisible = false;
				CantDelivery.IsVisible = false;
				TipoVentana.IsVisible = false;
				CantTramos.IsVisible = false;
				radioGroup5.IsVisible = false;
				radioGroup6.IsVisible = false;
				radioGroup7.IsVisible = false;
				radioGroup8.IsVisible = false;
				radioGroup9.IsVisible = false;
				radioGroup10.IsVisible = false;
				radioGroup11.IsVisible = false;
				radioGroup12.IsVisible = false;
				radioGroup13.IsVisible = false;
				SeccionRbDC.IsVisible = false;
				LBPreg1.IsVisible = false;
				LBPreg2.IsVisible = false;
				LBPreg3.IsVisible = false;
				LBPreg4.IsVisible = false;
				LBPreg5.IsVisible = false;
				LBPreg6.IsVisible = false;
				LBPreg7.IsVisible = false;
				LBPreg8.IsVisible = false;
				LBPreg9.IsVisible = false;
				LBPreg10.IsVisible = false;
				LBPreg11.IsVisible = false;
				LBPreg12.IsVisible = false;
				LBPreg13.IsVisible = false;
				LBPreg14.IsVisible = false;
				SeccionPickerD.IsVisible = false;
				SeccionPickerAC.IsVisible = false;
				SeccionPickerTC.IsVisible = false;
				SeccionRbCC.IsVisible = false;
				SeccionCC.IsVisible = false;
				SeccionPickerTV.IsVisible = false;
				SeccionIV.IsVisible = false;
				SeccionSM.IsVisible = false;
				SeccionCompetencia.IsVisible = false;
			}
			else
			{
				radioGroup1.IsVisible = true;
				radioGroup2.IsVisible = true;
				radioGroup3.IsVisible = true;
				SBEstadoD.IsVisible = true;
				SBAcceso.IsVisible = true;
				SBTa.IsVisible = true;
				radioGroup4.IsVisible = true;
				CantDelivery.IsVisible = true;
				TipoVentana.IsVisible = true;
				CantTramos.IsVisible = true;
				radioGroup5.IsVisible = true;
				radioGroup6.IsVisible = true;
				radioGroup7.IsVisible = true;
				radioGroup8.IsVisible = true;
				radioGroup9.IsVisible = true;
				radioGroup10.IsVisible = true;
				radioGroup11.IsVisible = true;
				radioGroup12.IsVisible = true;
				radioGroup13.IsVisible = true;
				SeccionRbDC.IsVisible = true;
				LBTipoVentana.IsVisible = true;
				LBPreg1.IsVisible = true;
				LBPreg2.IsVisible = true;
				LBPreg3.IsVisible = true;
				LBPreg4.IsVisible = true;
				LBPreg5.IsVisible = true;
				LBPreg6.IsVisible = true;
				LBPreg7.IsVisible = true;
				LBPreg8.IsVisible = true;
				LBPreg9.IsVisible = true;
				LBPreg10.IsVisible = true;
				LBPreg11.IsVisible = true;
				LBPreg12.IsVisible = true;
				LBPreg13.IsVisible = true;
				LBPreg14.IsVisible = true;
				SeccionPickerD.IsVisible = true;
				SeccionPickerAC.IsVisible = true;
				SeccionPickerTC.IsVisible = true;
				SeccionRbCC.IsVisible = true;
				SeccionCC.IsVisible = true;
				SeccionPickerTV.IsVisible = true;
				SeccionIV.IsVisible = true;
				SeccionSM.IsVisible = true;
				SeccionCompetencia.IsVisible = true;
			}
		}
		async private void BSiguiente_Clicked(object sender, EventArgs e)
		{
			var Colmado = Convert.ToString(SBColmados.SelectedItem);
			var EstadoFormulario = Convert.ToString(SBEstadoC.SelectedItem);
			var Resp1 = Convert.ToString(radioGroup1.CheckedItem);
			var Resp2 = Convert.ToString(radioGroup2.CheckedItem);
			var Resp3 = Convert.ToString(radioGroup3.CheckedItem);
			var Disposicion = Convert.ToString(SBEstadoD.SelectedItem);
			var Acceso = Convert.ToString(SBAcceso.SelectedItem);
			var Tamaño = Convert.ToString(SBTa.SelectedItem);
			var Resp4 = Convert.ToString(radioGroup4.CheckedItem);
			var CantidadDeliverys = CantDelivery.Text;
			var tipoVentana = Convert.ToString(TipoVentana.SelectedItem);
			var CantidadTramos = CantTramos.Text;
			var Resp5 = Convert.ToString(radioGroup5.CheckedItem);
			var Resp6 = Convert.ToString(radioGroup6.CheckedItem);
			var Resp7 = Convert.ToString(radioGroup7.CheckedItem);
			var Resp8 = Convert.ToString(radioGroup8.CheckedItem);
			var Resp9 = Convert.ToString(radioGroup9.CheckedItem);
			var Resp10 = Convert.ToString(radioGroup10.CheckedItem);
			var Resp11 = Convert.ToString(radioGroup11.CheckedItem);
			var Resp12 = Convert.ToString(radioGroup12.CheckedItem);
			var Resp13 = Convert.ToString(radioGroup13.CheckedItem);
			var Comentarios = Comment.Text;

			if (SBColmados != null && Colmado != "") { 

				if (SBEstadoC != null && EstadoFormulario != "")
				{
					if (radioGroup1.CheckedItem != null)
					{
						if (radioGroup2.CheckedItem != null)
						{
							if (radioGroup3.CheckedItem != null)
							{
								if (SBEstadoD != null && Disposicion != "")
								{
									if (SBAcceso != null && Acceso != "")
									{
										if (SBTa != null && Tamaño != "")
										{
											if (radioGroup4.CheckedItem != null)
											{
												if (CantDelivery.Text != null && CantidadDeliverys != "")
												{
													if (TipoVentana.SelectedItem != null || tipoVentana != "")
													{
														if (CantTramos.Text != null && CantidadTramos != "")
														{
															if (radioGroup5.CheckedItem != null)
															{
																if (radioGroup6.CheckedItem != null)
																{
																	if (radioGroup7.CheckedItem != null)
																	{
																		if (radioGroup8.CheckedItem != null)
																		{
																			if (radioGroup9.CheckedItem != null)
																			{
																				if (radioGroup10.CheckedItem != null)
																				{
																					if (radioGroup11.CheckedItem != null)
																					{
																						if (radioGroup12.CheckedItem != null)
																						{
																							if (radioGroup13.CheckedItem != null)
																							{
																								if (Comment.Text != null && Comentarios != "")
																								{
																									await DisplayAlert("Aviso","Los datos fueron guardados correctamente","Ok");
																									SBColmados.SelectedItem = SBColmados;
																									SBEstadoC.SelectedItem = SBEstadoC;
																									radioGroup1 = radioGroup1;
																									radioGroup2 = radioGroup2;
																									radioGroup3 = radioGroup3;
																									SBEstadoD.SelectedItem = SBEstadoD;
																									SBAcceso.SelectedItem = SBAcceso;
																									SBTa.SelectedItem = SBTa;
																									radioGroup4 = radioGroup4;
																									CantDelivery.Text = "";
																									TipoVentana.SelectedItem = TipoVentana;
																									CantTramos.Text = "";
																									radioGroup5 = radioGroup5;
																									radioGroup6 = radioGroup6;
																									radioGroup7 = radioGroup7;
																									radioGroup8 = radioGroup8;
																									radioGroup9 = radioGroup9;
																									radioGroup10 = radioGroup10;
																									radioGroup11 = radioGroup11;
																									radioGroup12 = radioGroup12;
																									radioGroup13 = radioGroup13;
																									Comment.Text = "";

																									await Navigation.PushModalAsync(new NavigationPage(new EventoCamara()));
																								}
																								else
																								{
																									await DisplayAlert("Error","No puede dejar el campo comentario vacío","Ok");
																									return;
																								}
																							}
																							else
																							{
																								await DisplayAlert("Error", "Debe seleccionar una respuesta en Ristras Downy", "Ok");
																								return;
																							}
																						}
																						else
																						{
																							await DisplayAlert("Error", "Debe seleccionar una respuesta en Ristras OB", "Ok");
																							return;
																						}
																					}
																					else
																					{
																						await DisplayAlert("Error", "Debe seleccionar una respuesta en Brillante 150ml", "Ok");
																						return;
																					}
																				}
																				else
																				{
																					await DisplayAlert("Error", "Debe seleccionar una respuesta en Menta 100ml", "Ok");
																					return;
																				}
																			}
																			else
																			{
																				await DisplayAlert("Error", "Debe seleccionar una respuesta en Menta 50ml", "Ok");
																				return;
																			}
																		}
																		else
																		{
																			await DisplayAlert("Error", "Debe seleccionar una respuesta en Menta 22ml", "Ok");
																			return;
																		}
																	}
																	else
																	{
																		await DisplayAlert("Error", "Debe seleccionar una respuesta en Ristra Crema y Cepillos", "Ok");
																		return;
																	}
																}
																else
																{
																	await DisplayAlert("Error", "Debe seleccionar una respuesta en Ristra Jabon Protex", "Ok");
																	return;
																}
															}
															else
															{
																await DisplayAlert("Error", "Debe seleccionar una respuesta en Ristra Triple Accion", "Ok");
																return;
															}

														}
														else
														{
															await DisplayAlert("Error", "No puede dejar Cantidad de Tramos vacía", "Ok");
															return;
														}
													}
													else
													{
														await DisplayAlert("Error", "Debe seleccionar un tipo de ventana", "Ok");
														return;
													}
												}
												else
												{
													await DisplayAlert("Error", "No puede dejar Cantidad de delivery vacía", "Ok");
													return;
												}
											}
											else
											{
												await DisplayAlert("Error", "Debe seleccionar una respuesta en ¿Tiene dos o mas refrigeradores?", "Ok");
												return;
											}
										}
										else
										{
											await DisplayAlert("Error", "Debe seleccionar un tamaño para el colmado", "Ok");
											return;
										}
									}
									else
									{
										await DisplayAlert("Error", "Debe seleccionar el tipo de acceso al colmado", "Ok");
										return;
									}
								}
								else
								{
									await DisplayAlert("Error", "Debe seleccionar la dispocision del colmadero", "Ok");
									return;
								}
							}
							else
							{
								await DisplayAlert("Error", "Debe seleccionar una respuesta en ¿Permite la entrada aun con la situacion del Coronavirus?", "Ok");
								return;
							}
						}
						else
						{
							await DisplayAlert("Error", "Debe seleccionar una respuesta en ¿Permite material POP?", "Ok");
							return;
						}
					}
					else
					{
						await DisplayAlert("Error", "Debe seleccionar una respuesta en ¿Deja pasar?", "Ok");
						return;
					}

				}
				else
				{
					await DisplayAlert("Error", "Debe seleccionar el estado del colmado", "Ok");
					return;
				}

			}
			else
			{
				await DisplayAlert("Error", "Debe seleccionar un colmado", "Ok");
				return;
			}

		}

		
	}
	
}